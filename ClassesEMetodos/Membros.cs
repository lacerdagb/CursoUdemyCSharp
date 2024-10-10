using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Gabriel";
            sicrano.Idade = 25;

            // Console.WriteLine($"O {sicrano.Nome} tem exatamento {sicrano.Idade} anos.");

             sicrano.ApresentarNoConsole(); // Retorna da classe pessoa, direto no console
            sicrano.Zerar(); // Vazio
             sicrano.ApresentarNoConsole(); 

            var fulano = new Pessoa();
            fulano.Nome = "Lacerda";
            fulano.Idade = 20;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);

        }
    }
}
