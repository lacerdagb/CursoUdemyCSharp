﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89); // Esse produto é da coleção lista
            var p2 = new Produto("Caneta", 1.89); 
            var p3 = p2;

            Console.WriteLine(p1 == p2); // Vai dar false, pois cada um aponta para um local de memória diferente
            Console.WriteLine(p3 == p2); // aponta por referência, para o mesmo lugar, comparação 


            Console.WriteLine(p1.Equals(p2)); // Faz a mesma coisa para endereço de memória (==)

        }
    }
}
