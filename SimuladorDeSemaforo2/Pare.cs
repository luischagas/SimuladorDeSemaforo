using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimuladorDeSemaforo
{
    public class Pare : EstadoDoSemaforo
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
}
