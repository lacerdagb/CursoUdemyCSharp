using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar()
        {
            // double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota); // Essa aqui, você digita o valor
            double notaDeCorte = 7.0;

            Console.WriteLine("Sua nota é {0}", nota);
            Console.WriteLine("Nota invalida? {0}", nota > 10.0);
            Console.WriteLine("Nota invalida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por média?{0}", nota >= notaDeCorte);
            Console.WriteLine("Ele está de recuperação?{0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3);
            


        }
    }
}