using System;
using Encapsulamento; // Importar referência do namespace do subcelebridade

namespace CursoCSharp.OO
{
    internal class Encapsulamento
    {
        public class FilhoNaoReconhecido : SubCelebridade
        {
            public new void MeusAcessos()
            {
                Console.WriteLine("FilhoNaoReconhecido...");

                Console.WriteLine(infoPublica);
                Console.WriteLine(CorDoOlho);
                //Console.WriteLine(NumeroDoCelular);
                Console.WriteLine(JeitoDeFalar);
                //Console.WriteLine(SegredoDeFamilia);
                //Console.WriteLine(UsaMuitoPhotoshop);
            }
        }
        public class AmigoDistante
        {
            public readonly SubCelebridade amiga = new SubCelebridade();

            public void MeusAcessos()
            {
                Console.WriteLine("AmigoDistante...");

                Console.WriteLine(amiga.infoPublica);
                //Console.WriteLine(amiga.CorDoOlho);
                //Console.WriteLine(amiga.NumeroCelular);
                //Console.WriteLine(amiga.JeitoDeFalar);
                //Console.WriteLine(amiga.SegredoFamilia);
                //Console.WriteLine(amiga.UsaMuitoPhotoshop);

            }
        }
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
