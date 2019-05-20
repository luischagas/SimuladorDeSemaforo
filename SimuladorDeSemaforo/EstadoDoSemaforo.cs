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

    class Pare : EstadoDoSemaforo
    {
        public Pare(Semaforo semaforo) : base(semaforo, ConsoleColor.Red)
        {

        }

        public override EstadoDoSemaforo ProximoEstado()
        {
            AscendeLampada();

            Thread.Sleep(5000);

            return new Prossiga(Semaforo);
        }
    }

    class Atencao : EstadoDoSemaforo
    {
        public Atencao(Semaforo semaforo) : base(semaforo, ConsoleColor.Yellow)
        {

        }

        public override EstadoDoSemaforo ProximoEstado()
        {
            ApagaLampada();

            Thread.Sleep(500);

            PiscaLampada();

            PiscaLampada();

            PiscaLampada();

            return new Pare(Semaforo);
        }

        private void PiscaLampada()
        {
            AscendeLampada();

            Thread.Sleep(1000);

            ApagaLampada();

            Thread.Sleep(500);
        }
    }

    class Prossiga : EstadoDoSemaforo
    {
        public Prossiga(Semaforo semaforo) : base(semaforo, ConsoleColor.Green)
        {

        }

        public override EstadoDoSemaforo ProximoEstado()
        {
            AscendeLampada();

            Thread.Sleep(5000);

            return new Atencao(Semaforo);
        }
    }
}
