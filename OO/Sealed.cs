using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    sealed class SemFilho // metodo selado não pode ser sobrescrito.
    {
        public double ValorDaFoturna()
        {
            return 1_500_500;
        }
    }
    //class SouFilho :  SemFilho
    //{
    //}
    class Avo
    {
        public virtual bool HonrarNomeFamilia() // Virtual permite a sobrescrita, e o sealed não.
        {
            return true;
        }
    }
    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class FilhoRebelde : Pai
    {
        //public new bool HonrarNomeFamilia() // Nao posso botar override no lugar do new
        //{
        //    return false;
        //}
    }
    internal class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFoturna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());

        }
    }
}

