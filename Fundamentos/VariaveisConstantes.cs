using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisConstantes
    {
        public static void Executar()
        {
            // Tipos internos

            bool estaChovendo = true; // Posso botar false
            Console.WriteLine("Está chovendo " + estaChovendo);

            Console.WriteLine();
            Console.WriteLine("NÚMERO INTEIRO");

            byte idade = 45; // vai de 128 caracteres, so usar as variações, se for muito especifico, em geral é int
            // sbyte, short
            // posso usar ( short salario = short.MaxValue;) vai dar o maior valor do tipo
            Console.WriteLine("Idade " + idade);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor int" + menorValorInt);

            uint populacaoBrasileira = 200_000_000; // para ficar mais fácil de ler;
            Console.WriteLine("Valor da população brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue; // Números gigantes
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; // Números gigantes, com _ para separar valores
            Console.WriteLine("População mundial " + populacaoMundial);

            Console.WriteLine();
            Console.WriteLine("NÚMERO REAL");

            double PG = 3100.99;
            Console.WriteLine("Pg na conta " + PG);

            float precoComputador = 3599.99f; // Melhor usar o double, e tem ue ser marcado com o f no final
            Console.WriteLine("Preço do computador " + precoComputador);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // Maior número
            Console.WriteLine("Dsitância entre estrelas " + distanciaEntreEstrelas);

            Console.WriteLine();
            Console.WriteLine("LETRAS");

            char letra = 'b';
            Console.WriteLine("letra a, " + letra);

            string texto = "Estou gostando muito do curso de C#";
            Console.WriteLine(texto);

        }
    }
}
