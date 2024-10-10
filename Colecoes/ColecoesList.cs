using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.ClassesEMetodos.AtributosEstaticos;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

     public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public override bool Equals(object obj) //Faz parte do exercicio de Igualdade
        {
            Produto outroProduto = (Produto)obj;
        bool mesmoNome = Nome == outroProduto.Nome;
        bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
    }
        public override int GetHashCode() //Não ficou muito claro
        {
            return Nome.Length;
        }


    }


    internal class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne",49.9);

            var carrinho = new List<Produto>(); // lista homogenea, cresce dinâmicamente, aceita repetição, estrutura indexada.
            carrinho.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8º temp game os thrones", 99.9),
                new Produto("Poster", 10)
            };
            carrinho.AddRange(combo); // metodo ue pega tudo
            Console.WriteLine(carrinho.Count); // Conta quantos itens tem no carrinho. (4)
            carrinho.RemoveAt(3); // Ele vai remover o 3 item

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item)); 
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro); // aceita repetição
            Console.WriteLine(carrinho.LastIndexOf(livro)); // o ultimo indice (3)
        }
    }
}
