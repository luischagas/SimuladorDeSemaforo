using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeSemaforo
{
    public class LampadaQuadrada : Lampada
    {
        public LampadaQuadrada()
        {

        }

        protected override string ObtemCaracteristica()
        {
            return @" XXXXXXXXX
 XXXXXXXXX
 XXXXXXXXX
 XXXXXXXXX";
        }
    }
}
