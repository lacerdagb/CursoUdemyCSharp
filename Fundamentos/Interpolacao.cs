﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + " reais.");

            Console.WriteLine();

            Console.WriteLine("O {0} da marca {1} custa {2} reais.", nome, marca, preco);

            Console.WriteLine();

            Console.WriteLine($"A marca {marca} é muito boa");

            Console.WriteLine($"1 + 1 = {1 + 1}"); // Posso fazer operações matemáticas dentro da interpolação
        }
    }
}
