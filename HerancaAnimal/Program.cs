using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Herança
            Gato gato = new Gato();
            Console.WriteLine("peso: "+gato.peso+" idade: "+gato.idade);
            gato.Miar();

            Cachorro cachorro = new Cachorro();
            Console.WriteLine("peso: " + cachorro.peso + " idade: "+cachorro.idade);
            cachorro.Latir();

            //Polimorfismo
            List<Animal> list = new List<Animal>();
            list.Add(gato);
            list.Add(cachorro);

            foreach(Animal pet in list)
            {
                Console.WriteLine("Este Animal é do tipo: "+pet.GetType().Name);
            }

            Console.ReadKey();

        }
    }
}
