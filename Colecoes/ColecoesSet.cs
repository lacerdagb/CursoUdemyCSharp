using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{

    internal class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne",49.9);

            var carrinho = new HashSet<Produto>();  // HashSet não é indexado, logo o remover o índice 3... indexof... não funciona.
            // e não aceita repeticao
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8º temp game os thrones", 99.9),
                new Produto("Poster", 10)
            };
            carrinho.UnionWith(combo); // união de conjunto com lista, adiciona tudo que não tem duplicação
            Console.WriteLine(carrinho.Count); 
            //carrinho.RemoveAt(3); // Ele vai remover o 3 item

            foreach (var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item)); 
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro); // Não aceita repetição
            //Console.WriteLine(carrinho.LastIndexOf(livro)); // o ultimo indice (3)
        }
    }
}
