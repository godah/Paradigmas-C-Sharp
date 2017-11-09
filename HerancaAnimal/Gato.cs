using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAnimal
{
    class Gato : Animal
    {
        internal Gato()
        {
            peso = (float)2.2;
            idade = 1;
        }
        internal override string Morde()
        {
            return "O gato Mordeu.";
        }

        internal void Miar()
        {
            Console.WriteLine("Miau.");
        }
    }
}
