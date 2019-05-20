using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimuladorDeSemaforo
{
    public abstract class EstadoDoSemaforo
    {
        public Semaforo Semaforo { get; private set; }

        public ConsoleColor Cor { get; private set; }

        public EstadoDoSemaforo(Semaforo semaforo, ConsoleColor cor)
        {
            Semaforo = semaforo;

            Cor = cor;
        }

        public abstract EstadoDoSemaforo ProximoEstado();

        protected void AscendeLampada()
        {
            Semaforo.Lampada.Acende(Cor);
        }

        protected void ApagaLampada()
        {
            Semaforo.Lampada.Apaga();
        }
    }
}
