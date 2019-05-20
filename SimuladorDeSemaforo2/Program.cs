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

            TipoDeLampada tipoDeLampada;

            var tipoDeSemaforo = Console.ReadKey();

            if (tipoDeSemaforo.Key == ConsoleKey.V)
            {
                tipoDeLampada = TipoDeLampada.Redonda;
            }
            else if (tipoDeSemaforo.Key == ConsoleKey.P)
            {
                tipoDeLampada = TipoDeLampada.Quadrada;
            }
            else
            {
                throw new InvalidOperationException("Opção inválida.");
            }

            var semaforo = new Semaforo(tipoDeLampada);

            semaforo.Liga();

            Console.WriteLine("Pressione qualquer tecla para terminar...");

            Console.ReadLine();
        }
    }
}
