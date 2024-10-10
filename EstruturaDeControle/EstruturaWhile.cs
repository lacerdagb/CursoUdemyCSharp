using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaWhile
    {

        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

             int numeroSecreto = random.Next(1, 16); // Embaralha os números, de 1 até 15, não até o 16
            bool numeroEncontrado = false;
            int tentativaRestante = 5;
            int tentativas = 0;

            while (tentativaRestante > 0 && !numeroEncontrado)
            {
                Console.Write("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativaRestante--;
                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true; // para confirmar, e sair do while
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("Número encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                    Console.WriteLine();
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes {0}", tentativaRestante);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Maior... Tente novamente");
                    Console.WriteLine("Tentativas restantes {0}", tentativaRestante);
                    Console.WriteLine();
                }
            }
        }
    }
}
