﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do // Usado para quantidade indeterminada de repetição, o codigo vai primeiro.
            {
                Console.WriteLine("Qual é o seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem vindo {0}", entrada);
                Console.WriteLine("Deseja continuar? (S/N)");
                entrada = Console.ReadLine();
            }
            while (entrada.ToLower() == "s"); 

        }
    }
}
