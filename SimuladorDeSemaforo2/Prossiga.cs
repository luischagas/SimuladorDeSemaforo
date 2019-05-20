using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimuladorDeSemaforo
{
   public class Prossiga : EstadoDoSemaforo
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
