using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAnimal
{
    class Cachorro : Animal
    {
        internal Cachorro()
        {
            peso = (float)3.4;
            idade = 2;
        }

        internal override string Morde()
        {
            return "O Cachorro mordeu.";
        }

        internal void Latir()
        {
            Console.WriteLine("Au au.");
        }
    }
}
