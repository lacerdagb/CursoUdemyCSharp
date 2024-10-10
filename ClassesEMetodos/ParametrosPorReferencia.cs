using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero) // se conecta com o ref
        {
            numero = numero + 1000;
        }
        public static void AlterarOut(out int numero1, out int numero2) // o out , menos chance de bug ue o ref, pode botar mais valores
        {
            numero1 = 0;
            numero2 = 0;
            numero1 = numero1 + 15;
            numero2 = numero2 + 30;
        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef( ref a); // Se conecta com o ref
            Console.WriteLine(a);

           // int b; não tem sentido int b = 2, õ out não aceita.
            AlterarOut(out int b, out int c);
            Console.WriteLine ($"{b} {c}");
        }
    }
}
