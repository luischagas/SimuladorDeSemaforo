using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeSemaforo
{
    public abstract class Lampada
    {
        public Lampada()
        {
            Caracteristica = ObtemCaracteristica();
        }

        protected abstract string ObtemCaracteristica();

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
