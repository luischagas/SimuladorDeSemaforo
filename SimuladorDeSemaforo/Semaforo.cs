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

        private bool ativo;

        public Lampada Lampada { get; private set; }

        public Semaforo(Lampada lampada)
        {
            Lampada = lampada;

            Console.WriteLine("Criando semáforo...");

            estado = new Desligado(this);

            ativo = false;
        }

        public void Liga()
        {
            Console.WriteLine("Ligando semáforo...");
            estado.ProximoEstado();

            ativo = true;

            while (ativo)
            {
                estado = estado.ProximoEstado();
            }
        }

        public void Desliga()
        {
            Console.WriteLine("Desligando semáforo...");

            ativo = false;
        }
    }
}
