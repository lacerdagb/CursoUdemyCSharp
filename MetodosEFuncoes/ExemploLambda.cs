using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    internal class ExemploLambda
    {
        public static void Executar()
        {
            Action<string> algoNoConsole = (a) => // Action não tem retorno, é void
            {
                Console.WriteLine("Lambda com C#" + a); // posso botar o parâmetro ou não, mas tem ue tirar o <string>
            };
            algoNoConsole("!!!"); /// posso deixar vazio

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogarDado());

            // Func<int, string> conversorHex = numero => numero.ToString("X"); ---> uma linha só, é o mesmo do de baixo

            Func<int, string> conversorHex = (numero) => // quando tem mais de 2 parâmetros, o último passado é o tipo de retorno
            {
                Random random = new Random();
                return numero.ToString("X");
            };
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => // dia, mes e ano não tem int, pois ja foi declarada no inicio
                 String.Format($"{dia}/{mes}/{ano}"); // Como é uma sentença apenas, não precisa do return
            Console.WriteLine(formatarData(1, 1, 2024));
        }
    }
}
