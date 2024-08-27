using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano); // D2, bota zero a esquerda
        }
        public static void Executar() // As vezes é melhor escrever um pouco mais, porém um codigo claro, do ue uma linha curta e complexo.
        {
            Formatar(mes: 8, dia: 1, ano: 2018);
        }
    }
}
