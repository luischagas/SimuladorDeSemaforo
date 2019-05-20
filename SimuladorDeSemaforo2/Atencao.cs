using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimuladorDeSemaforo
{
    public class Atencao : EstadoDoSemaforo
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
}
