using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public abstract class Celular // Classe ganha vida, não consegue instanciar
    {
        public abstract string Assistente(); // Posso instanciar samsung, iphone, mas não posso celular, pois é abstrato
        public string Tocar()
        {

            return "Trim trim trim...";
        }
    }
        public class Samsung : Celular
        {
            public override string Assistente()
            {
                return "Olá! Meu nome é Bixby";
            }
        }
        public class Iphone : Celular
        {
            public override string Assistente()
            {
                return "Olá! Meu nome é Siri!";
            }
        }
    
    internal class Abstract
    {
        public static void Executar()
        {
            // Celular c = new Celular();  vai dar erro
            var celulares = new List<Celular>
            {
               new Iphone(),
               new Samsung()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }


        }
    }
}
