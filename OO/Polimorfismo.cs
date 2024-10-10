using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Comida // Polimorfismo dinâmico, sem sobrecarregar o metódo
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }
        public Comida()
        {

        }
    }

    internal class Polimorfismo
    {
        public class Feijao : Comida  //Antes não tinha comida, entrou por conta do poli 
        {
            //public double Peso;
        }
        public class Arroz : Comida
        {
            //public double Peso;
        }
        public class Carne : Comida
        {
            //public double Peso;
        }
        public class Pessoa // Não forçar herança, o humano não é comida, por isso ele não entrou
        {
            public double Peso;

            //public void Comer(Feijao feijao)
            //{
            //    Peso += feijao.Peso;
            //}
            //public void Comer(Arroz arroz)
            //{
            //    Peso += arroz.Peso;
            //}
            //public void Comer(Carne carne)
            //{
            //    Peso += carne.Peso;
            //}
            public void Comer(Comida comida)
            {
                Peso += comida.Peso;
            }
        }
        public static void Executar()
        {
            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso} kg!");

        }
    }
}
