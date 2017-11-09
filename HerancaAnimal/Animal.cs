using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAnimal
{
    abstract class Animal
    {
        internal float peso { get; set; }
        internal int idade { get; set; }

        abstract internal string Morde();
    }
}
