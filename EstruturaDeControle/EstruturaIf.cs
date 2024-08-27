using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota); // Vai converter a nota do aluno, se for valor inválido, retorna 0

            Console.WriteLine("Possui bom comportamento? (s/n)");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")  ===> metodo 1, usando if
            //    bomComportamento = true;

            //bomComportamento = entrada == "S" || entrada == "s"; ===> metodo 2, simplificando

            bomComportamento = entrada.ToLower() == "s"; // ===> metodo 3, simplificando. Força botar no diminutivo

            if (nota >= 9.0 && bomComportamento) // quando a variavel ja e boleana, não precisa botar bomComportamento == true
            {
               Console.WriteLine("Quadro de honra!");
            }
            // Estrutura de controle, não tem ;
        }
    }
}
