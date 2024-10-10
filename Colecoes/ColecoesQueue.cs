using System;
using System.Collections.Generic;
using System.Collections; // Tive que botar para rodar o queue sozinho
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>(); // amarrando para que todos os tipos sejam string, aceita repetição
            fila.Enqueue("fulano");
            fila.Enqueue("sicrano");
            fila.Enqueue("beltrano");
            fila.Enqueue("beltrano");

            Console.WriteLine(fila.Peek()); // Pega o primeiro elemento da fila, que é o próximo a sair, mas não tira da lista
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue()); // Ele tira o primeiro da fila
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue(); // so o queue não pega, diferente da linha 13 ue tem o Generic <string>, tive que add no System
            salada.Enqueue(3);
            salada.Enqueue("item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item")); // contém item na lista: True. Tem que estar escrito igual
            Console.WriteLine(salada.Contains("Item")); // contém item na lista: False. Ta em maiusculo.

        }
    }
}
