using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1; // Embora não tenha a palavra private, ela é privada, não consigo acessar no Executar.
        string nome; // minúsculo é privado
        public string Nome // maiúsculo é publica
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); // Lambda
            //get { return Preco - (desconto * Preco);
            //}
        }
        public CarroOpcional() // Construtor padrão, vazio
        {

        }
        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    internal class Props // Propriedades
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);
            // op1.PrecoComDesconto = 3000; Errado, pois a propriedade é so leitura.

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
