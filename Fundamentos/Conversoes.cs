using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10; // Conversão implicita
            double quebrado = inteiro;
            Console.WriteLine(inteiro);

            double nota = 9.7; // Conversão explicita
            int notaTruncada = (int)nota; // (int) é tipo eu sei o que estou fazendo, tenho responsabilidade e sei que perderei dados.
            Console.WriteLine("Nota Truncada: " + notaTruncada);

            //Metodo 1
            Console.WriteLine("Digite a sua idade");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade Inserida:" + idadeInteiro);

            //Metodo 2
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado " + idadeInteiro);

            //Metodo 3
            Console.WriteLine("Digite um número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado número:" + numero);
            /* Posso escrever teste que o resultado dara 0, ou seja, S/A
             * O TryParse, testa converter, sse não conseguir, ele bota o valor 0
             */

            //Metodo 4
            Console.WriteLine("Digite o segundo número");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("O resultado do 2 numero é" + numero2); 
           
            
        }
    }
}
