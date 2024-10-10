using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto (string marca, string modelo, uint cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }
        public Moto()
        {

        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public uint GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetCilindrada(uint cilindrada) // botando todos os uint para obrigar a botar valor positivo, negativo dar erro.
        {
            Cilindrada = cilindrada;
        }
    }
    internal class GetSet // Get lê, Set altera
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetModelo("Honda");
            moto2.SetMarca("CG");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
            // Tem mais coisa, mas eu decidir seguir adiante

        }
    }
}
    
