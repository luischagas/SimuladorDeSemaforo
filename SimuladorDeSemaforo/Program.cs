using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorDeSemaforo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar o tipo de semáforo que deseja criar. (P / V)");

            Lampada lampada;

            var tipoDeSemaforo = Console.ReadKey();

            if (tipoDeSemaforo.Key == ConsoleKey.V)
            {
                lampada = new LampadaRedonda();
            }
            else if (tipoDeSemaforo.Key == ConsoleKey.P)
            {
                lampada = new LampadaQuadrada();
            }
            else
            {
                throw new InvalidOperationException("Opção inválida.");
            }

            var semaforo = new Semaforo(lampada);

            semaforo.Liga();

            Console.WriteLine("Pressione qualquer tecla para terminar...");

            Console.ReadLine();
        }
    }
}
