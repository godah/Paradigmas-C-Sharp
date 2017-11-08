using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Função
            Console.WriteLine("\nFunção");
            Console.Write(Soma(321.3123, 1213.231));

            //Método
            Console.WriteLine("\nMetodo");
            Primeiro primeiro = new Primeiro();
            Console.WriteLine(primeiro.numero+" "+primeiro.descricao);
            primeiro.numero = 2;
            primeiro.descricao = "Funciona";
            Console.WriteLine(primeiro.numero + " " + primeiro.descricao);
           
            //Objeto
            Console.WriteLine("\nObjeto");
            Conta conta = new Conta();
            Console.WriteLine("Construtor de Conta"+conta.conta);

            //Herança
            Console.WriteLine("\nHerança");
            Fisica fisica = new Fisica();
            Console.WriteLine("Construtor de Fisica conta:" + fisica.conta+" cpf: "+fisica.cpf);

            Console.WriteLine("\nAlterando valores");
            fisica.conta = 123123123;
            fisica.cpf = "045.451.156-84";
            Console.WriteLine("Fisica conta:" + fisica.conta + " cpf: " + fisica.cpf);

            Juridica juridica = new Juridica();
            Console.WriteLine("Construtor de Juridica conta:" + juridica.conta + " cnpj: " + juridica.cnpj);

            Console.WriteLine("\nAlterando valores");
            juridica.conta = 23345234;
            juridica.cnpj = "01.015.150/0001-12";
            Console.WriteLine("Juridica conta:" + juridica.conta + " cnpj: " + juridica.cnpj);

            
            //Polimorfismo
            Console.WriteLine("\nPolimorfismo");
            Console.WriteLine("\nUso do Typecast para Conta se comportar como Fisica");
            Conta contagenerica = new Fisica();
            Console.WriteLine("Construtor de Fisica conta:" + contagenerica.conta + " cpf: " + ((Fisica)contagenerica).cpf);

            Console.WriteLine("\nAlterando valores");
            contagenerica.conta = 123123123;
            ((Fisica)contagenerica).cpf = "045.451.156-84";
            Console.WriteLine("Fisica conta:" + contagenerica.conta + " cpf: " + ((Fisica)contagenerica).cpf);

            //Lista polimorfismo
            Console.WriteLine("\nLista Polimorfismo");
            List<Conta> lista = new List<Conta>();
            lista.Add(new Fisica());
            lista.Add(new Juridica());
            lista.Add(new Fisica());

            foreach(var item in lista)
            {
                Console.WriteLine("conta: "+conta.conta);
            }



            //Polimorfismo figura Geometrica
            Console.WriteLine("\nPolimorfismo Figura Geometrica");
            Figura figura = new Circulo();
            figura.CalcularArea();
            figura.CalcularPerimetro();


            //break
            Console.ReadLine();
        }

        private static double Soma(double a, double b)
        {
            return a + b;
        }


    }
}

