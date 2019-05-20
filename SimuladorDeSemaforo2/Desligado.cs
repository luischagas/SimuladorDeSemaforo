using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeSemaforo
{
    public class Desligado : EstadoDoSemaforo
    {
        public Desligado(Semaforo semaforo) : base(semaforo, ConsoleColor.Black)
        {

        }

        public override EstadoDoSemaforo ProximoEstado()
        {
            return new Prossiga(this.Semaforo);
        }
    }
}
