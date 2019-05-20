using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeSemaforo
{
    public class Lampada
    {
        public Lampada(TipoDeLampada tipo)
        {
            switch (tipo)
            {
                case TipoDeLampada.Quadrada:
                    Caracteristica = @" XXXXXXXXX
 XXXXXXXXX
 XXXXXXXXX
 XXXXXXXXX";

                    break;
                case TipoDeLampada.Redonda:
                    Caracteristica = @"     O     
  OOOOOOO
 OOOOOOOOO
  OOOOOOO
     O     ";
                    break;

                default:

                    break;
            }
        }

        public string Caracteristica { get; private set; }

        public void Acende(ConsoleColor cor)
        {
            Console.Clear();

            var corPadrao = Console.ForegroundColor;

            Console.ForegroundColor = cor;

            Console.WriteLine(Caracteristica);

            Console.ForegroundColor = corPadrao;
        }

        public void Apaga()
        {
            Console.Clear();
        }
    }
}
