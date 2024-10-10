using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            // ToUpper - maiusculo
            // Insert - Inserir palavra
            // Replace - substituir 

            var saudacao = "ola".ToUpper().Insert(3, " World!").Replace("World!" , "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length); // Conta a quantidade letras.

            string valorImportante = null; // valor vazio
            Console.WriteLine(valorImportante?.Length);
            // Navegação segura. Ponto de interrogação, afirma que o valor só é acessado se tiver vazio, se não tiver, da erro.
        }
    }
}
