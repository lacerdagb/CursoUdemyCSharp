using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametroPadrão
    {
        public static int Somar(int a = 1, int b = 1)
        {
            return a + b;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar(10, 23)); // somou os valores
            Console.WriteLine(Somar(50)); // como só tem um valor, pegou o valor e somou com 1
            Console.WriteLine(Somar()); // como não tem valores somou 1 + 1
            Console.WriteLine(Somar(b: 7)); // parametro a assumiu 1 + o b 7 ue da 8 somando 
            
        }
    }
}
