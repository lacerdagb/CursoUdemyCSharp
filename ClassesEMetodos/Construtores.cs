using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{   class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro() // Construtor vazio para rodar Carro.
        {

        }
    }
    internal class Construtores
    {
        public static void Executar() 
        {
            var carro1 = new Carro(); // Metodo 1
            // Construtor mesmo nome da classe.** // Como teve outro construtor com parâmetro, ele perde 
            // o construtor padrão.
            carro1.Fabricante = "BMW";
            carro1.Modelo = "375i";
            carro1.Ano = 2017;
            Console.WriteLine(
                $"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

           
            var carro2 = new Carro("Ka", "Ford", 2018); // Metodo 2
            Console.WriteLine(
                $"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");


            var carro3 = new Carro() // Metodo 3
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}
