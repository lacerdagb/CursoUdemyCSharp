using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCSharp.OO.Carro;

namespace CursoCSharp.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }
        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;
            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }
        public virtual int Acelerar() // O virtual para dar a permissão para ser sobrescrito
        {
            return AlterarVelocidade(5);
        }
        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
        public class Uno : Carro // Construtor base, Uno vai receber todos os parâmetros do carro que está acima.
        {
            public Uno() : base(200) // Como não tem construtor padrão acima (construtor sem parâmetros), explicitamente chamo um constr
                                     // 200 é a velocidade máxima
            {

            }
        }
    }
    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }
        public override int Acelerar()
        { // override e sobescrever, e tem o virtual para dar a permissão, ou posso suar a forma do Frear abaixo
            return AlterarVelocidade(15);
        }
        public new int Frear() // a palavra new, evita de eu usar o override e o virtual, porém não é recomendável, 
                               // Vemos no exemplo do Ferrari com o tipo carro, o frear pega do carro e frea 5 e não 15
        {
            return AlterarVelocidade(-15);
        }
    }
    public class Heranca
    {
        public static void Executar()
        {        
          Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari(); 
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }


    }

}

