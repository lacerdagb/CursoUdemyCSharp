using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {   
        public static void Executar()
        {
            var nome = "Gabriel"; // O C# vê ue é cadeia de caracteres, e deduz para string
            // nome = 123; - é errado, pois ja foi inicializada com string
            Console.WriteLine(nome);

            // int idade; - é erraado pois não tem valor atribuido a ela.
            var idade = 25;
            Console.WriteLine("Minha idade é " + idade);

            int a;
            a = 3; // Posso criar a variável e depois atribuir.

            int b = 3; // Como posso atribuir na mesma linha
            Console.WriteLine(a + b);
        }
    }
}
