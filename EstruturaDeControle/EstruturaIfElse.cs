﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Sua nota está acima da média, parabéns");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
