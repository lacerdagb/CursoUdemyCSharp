﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }
    internal class ValorVsReferencia // Se você tem Struct, a passagem é por valor, Se tem Classe, a passagem é por referência.
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 21;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");


        }
       
    }
}
