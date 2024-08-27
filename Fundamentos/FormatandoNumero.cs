using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {   
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Casas
            Console.WriteLine(valor.ToString("C")); // Corrence, dinheiro
            Console.WriteLine(valor.ToString("P")); // Porcentagem
            Console.WriteLine(valor.ToString("#.##")); // Mesma coisa que F1

            CultureInfo cultura = new CultureInfo("pt-BR"); // en-US
            Console.WriteLine(valor.ToString("C0", cultura));
            /*C0 = R$ 15
             *C3 = R$ 15,175
             */
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // 0000000256 -> 0 a esquerda, usando para valor não muito significativo
        }
    }
}
