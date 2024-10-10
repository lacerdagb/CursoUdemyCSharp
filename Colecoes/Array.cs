using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5]; // Estrutura homogenea e estática, só tem um tipo. [5] só terá 5 elementos
            alunos[0] = "Gabriel"; //Array é uma estrutura indexada, através de índice
            alunos[1] = "Lacerda";
            alunos[2] = "Silviano";
            alunos[3] = "Ivete";
            alunos[4] = "Iraci";

            foreach (var aluno in alunos)
            { // foreach se encaixa muito bem com array, (Para cada valor, é uma linha)
                Console.WriteLine(aluno);
            }
            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }
            //for(int i = 0; i < notas.Length; i++) // Mesma coisa ue o foreach acima, mas é mais interresante usar o foreach, menos controle
            //{
            //    somatorio += notas[i];
            //}
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y'};
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
