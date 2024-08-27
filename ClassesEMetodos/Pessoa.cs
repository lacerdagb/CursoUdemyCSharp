using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Pessoa
    {
        public string Nome; // string tem valor padrão null
        public int Idade; // int tem valor padrão 0 

        public string Apresentar() // Aqui você monta a string
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole() // Aqui implementa o direto no console.
        {
            Console.WriteLine(Apresentar());
        }
        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
            
    }
}
