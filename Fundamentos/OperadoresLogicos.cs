using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true; // pode mudar para testar os operadores.
            var executouTrabalho2 = false;

            var comproTV50 = executouTrabalho1 && executouTrabalho2; // operador binario && 2 operando.
            Console.WriteLine("Comprou TV50 {0}", comproTV50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete);

            var comprouTV32 = executouTrabalho1 ^ executouTrabalho2;  // Essa deu pane por conta do símbolo.            
            Console.WriteLine($"Comprou a TV de 32{comproTV50}"); // ou exclusivo, só um tem que ser verdadeiro, se os dois for V, da F.

            Console.WriteLine("Mais saudável?{0}", !comprouSorvete); // operador unário, ! 1 operando. negação logica
        }
    }
}
