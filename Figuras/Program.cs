using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {

            //Herança
            Circulo circ = new Circulo();

            Quadrado quad = new Quadrado();

            Console.WriteLine("Circulo");
            Console.WriteLine("x: {0} y: {1} Area: {2}", circ.x,circ.y,circ.Area());

            Console.WriteLine("\nQuadrado");
            Console.WriteLine("x: {0} y: {1} Area: {2}", quad.x, quad.y, quad.Area());


            //Polimorfismo

            Figura fig = new Circulo();
            Console.WriteLine("\nCirculo Polimorfismo");
            Console.WriteLine("x: {0} y: {1} Area: {2}", fig.x, fig.y, ((Circulo)fig).Area());
            Console.WriteLine("x: {0} y: {1} Area: {2}", fig.x, fig.y, fig.Area());

            fig = new Quadrado();
            Console.WriteLine("\nQuadrado Polimorfismo");
            Console.WriteLine("x: {0} y: {1} Area: {2}", fig.x, fig.y, ((Quadrado)fig).Area());
            Console.WriteLine("x: {0} y: {1} Area: {2}", fig.x, fig.y, fig.Area());


            
            List<Figura> list = new List<Figura>();
            list.Add(new Quadrado());
            list.Add(new Circulo());
            list.Add(new Quadrado());
            list.Add(new Circulo());
            list.Add(new Quadrado());
            list.Add(new Circulo());
            list.Add(new Quadrado());
            list.Add(new Circulo());
            list.Add(new Quadrado());
            list.Add(new Circulo());
            list.Add(new Quadrado());
            list.Add(new Circulo());

            Console.WriteLine("\nList Polimorfismo com for()");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("x: {0} y: {1} Area: {2}", list[i].x, list[i].y, list[i].Area());
            }

            Console.WriteLine("\nList Polimorfismo com foreach()");
            foreach (Figura item in list)
            {
                Console.WriteLine("x: {0} y: {1} Area: {2}", item.x, item.y, item.Area());
            }


            Console.ReadKey();
        }
    }
}


