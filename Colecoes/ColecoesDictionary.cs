using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>(); // A chave não aceita repetição , mas o valor aceita

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem- Aranha");
            filmes.Add(2004, "Os incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) // mostra ue a chave está contida (tem)
            {
                Console.WriteLine("2004 " + filmes[2004]);
                Console.WriteLine("2004" + filmes.GetValueOrDefault(2008)); // Retorna o valor, ou retorna vazio
            }
            Console.WriteLine(filmes.ContainsValue("Amnesia")); // Vê se contém, como não tem, retorna false

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}"); // remove

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");

            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }
            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }
            foreach (KeyValuePair<int, string> filme in filmes) // Pega os dois valores, o ano e o filme, forma mais complicada
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
            foreach (var filme in filmes) // Faz a mesma coisa com o de cima, mas é mais fácil
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

        }
    }
}
