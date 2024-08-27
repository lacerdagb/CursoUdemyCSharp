using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";
            foreach (var letra in palavra) // uma repetição para cada letra, cada letra do opa vai ficar na vertical.
                Console.WriteLine(letra);

             var alunos = new string[] { "Lacerda", "Gabriel", "Silviano" }; // E cada elemento de um array.

            foreach (var aluno in alunos)
                Console.WriteLine(aluno);
        }
    }
}
