using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Metodo de Classe ou Metodo estático!!!!
        public static int Multiplicar (int a, int b) // Palavra estática é acessivel apartir de uma classe
        {
            return a * b;
        }
        // Metodo de instância
        public int Somar(int a, int b) // Só é acessível, apartir de uma instância.
        {
            return a + b;
        }
    }
    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: " + resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica(); // Instanciado
            Console.WriteLine(calc.Somar(2, 2));
            //Console.WriteLine(calc.Multiplicar(2, 2)); Não funciona, pois não da pra misturar com estatico.
        }
    }
}
