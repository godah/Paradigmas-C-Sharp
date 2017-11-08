using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVS
{
    public class Figura
    {
        public virtual void CalcularArea()
        {
            Console.WriteLine("Area Não definida");
        }

        public virtual void CalcularPerimetro()
        {
            Console.WriteLine("Perimetro Não definido");
        }
    }
}
