using System;
using System.Collections; // Tem que tirar o generics
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            foreach (var item in pilha)
            {
                Console.Write(item);
            }
            Console.WriteLine($"\nPop: {pilha.Pop()}"); // \n pula uma linha, Pega o primeiro item
            foreach (var item in pilha)
            {
                Console.Write(item);
            }
            Console.WriteLine($"\nPeek: {pilha.Peek()}"); // pega o próximo mas não remove
            Console.WriteLine(pilha.Count);
        }
    }
}
