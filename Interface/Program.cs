using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program : ICirculo, IQuadrado
    {
        public static void Main(string[] args)
        {
            ICirculo icirc = new Program();
            IQuadrado iquad = new Program();

            Console.WriteLine(icirc.calcularAreaCirculo());
            Console.WriteLine(iquad.calcularAreaQuadrado());

            Console.ReadKey();
        }

        double ICirculo.calcularAreaCirculo()
        {
            double a = 23.232;
            return a;
        }

        double IQuadrado.calcularAreaQuadrado()
        {
            double a = 324.23;
            return a;
        }
    }
}
