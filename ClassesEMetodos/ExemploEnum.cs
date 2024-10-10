using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia}; // enum usado para valores pre definidos

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    internal class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id); // o 0 é ação, 1 é aventura... 3 é animação

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknado 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} e {1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}
