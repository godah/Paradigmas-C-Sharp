using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVS
{
    public class Quadrado : Figura
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Area do Quadrado");
        }

        public override void CalcularPerimetro()
        {
            Console.WriteLine("Perimetro do Quadrado");
        }
    }
}
