using System;
using System.Collections;
// using System.Collections.Generic; tem ue tirar o generic, pois da problema
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesArrayList // valores heterogeneos, não sabe o time ue está trabalhando, muitos tipos
    {
        public static void Executar()
        {
            var arraylist = new ArrayList
            {
                "palavra",
                3,
                true
            };
            arraylist.Add(3.14);

            foreach(var item in arraylist)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType()); // vai explicar cada tipo é (string, int, boll)
            }
        }
    }
}
