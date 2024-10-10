using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Params
    {
        public static void Recepcionar(params string[] pessoas) // params recebe várias variáveis. 
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}", pessoa); // um olá para cada nome
            }
        }
        public static void Executar()
        {
            Recepcionar("Gabriel", "Lacerda", "Silviano");
        }
    }
}
