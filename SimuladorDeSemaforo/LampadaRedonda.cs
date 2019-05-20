using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeSemaforo
{
    public class LampadaRedonda : Lampada
    {
        public LampadaRedonda()
        {

        }

        protected override string ObtemCaracteristica()
        {
            return @"     O     
  OOOOOOO
 OOOOOOOOO
  OOOOOOO
     O     ";
        }
    }
}
