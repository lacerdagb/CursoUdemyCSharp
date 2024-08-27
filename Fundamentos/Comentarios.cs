using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{ /// <summary>
/// 
/// 
/// </summary>
    internal class Comentarios
    {   
        public static void Executar()
        {
            Console.WriteLine("Codigo claro é sempre melhor");
            Console.WriteLine();
            Console.WriteLine("Comentários simples");
            // Esse é comentário simples
            Console.WriteLine("O C# tem o XPL Comments");
            Console.WriteLine("/// em baixo da o summary");
            Console.WriteLine("Comentários em larga escala");
            Console.WriteLine("Posso selecionar as linhas de codigos e botar CTRL + U ou K");
            /*
             * 
             *  o enter já entra a linha com asteristico
             * 
            */
            Console.WriteLine("Boas práticas");
            // Não é interessante colocar o óbvio, sem poluição visual, cuidado com os comentários desnecessários.
            // Mas no contexto educacional é muito interessante comentar para entender
            // Você pode selecionar e apertar ctrl + K + C para comentar um bloco de codigo, ctrl + K + U descomentar



        }
    }
}
