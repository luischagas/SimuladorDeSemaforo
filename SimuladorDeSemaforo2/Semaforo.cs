using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimuladorDeSemaforo
{
    public class Semaforo
    {
        private EstadoDoSemaforo estado;

        public Lampada Lampada { get; private set; }

        public Semaforo(TipoDeLampada tipo)
        {
            Lampada = new Lampada(tipo);

            Console.WriteLine("Criando semáforo...");

            estado = new Desligado(this);
        }

        public void Liga()
        {
            Console.WriteLine("Ligando semáforo...");

            while (true)
            {
                estado = estado.ProximoEstado();
            }
        }       
    }
}
