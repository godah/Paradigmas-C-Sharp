using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soma
            /*
            int a, b, c;
            
            Console.WriteLine("Digite um valor para a");
            a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite um valor para b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para c");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: " + (a+b+c));
            Console.WriteLine("Produto: " + (a*b*c) );
            */

            //Media
            /*
            int a, b, c;

            Console.WriteLine("Digite um valor para a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para c");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Média: "+(a+b+c)/3);
            */

            //Média ponderada
            /*
            int a, b, c, d;

            Console.WriteLine("Digite um valor para a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para b");
            b = int.Parse(Console.ReadLine()) * 2;

            Console.WriteLine("Digite um valor para c");
            c = int.Parse(Console.ReadLine()) * 3;

            Console.WriteLine("Digite um valor para d");
            d = int.Parse(Console.ReadLine()) * 4;

            Console.WriteLine("Média: " + (a + b + c + d) / 4);
            */

            //Funções matematicas Math
            /*
            int a;
            Console.WriteLine("Digite um valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Cubo: " + Math.Pow(a,2));
            Console.WriteLine("Raiz Quadrada "+ Math.Sqrt(a));
            Console.WriteLine("Raiz Cubica " + Math.Pow(a,(1/4)));
            Console.WriteLine("Seno " + Math.Sin(a));
            Console.WriteLine("Cosseno " + Math.Cos(a));
            */

            //Modulação
            /*
            int a,b;
            Console.WriteLine("Digite um valor: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine(a%b);
            */

            //Condicional
            /*
            double sal;
            Console.WriteLine("Informe o salario: ");
            sal = int.Parse(Console.ReadLine());
            if (sal < 700)
            {
                sal = sal * 1.3;
            }
            else
            {
                sal = sal * 1.1;
            }
            Console.WriteLine("Novo salario: {0}",sal);
            */

            //Repetição
            /*
            int a = 1;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Digite 3 para sair.");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 0:
                        Console.WriteLine("Voce escolheu 0");
                        break;
                    case 1:
                        Console.WriteLine("Voce escolheu 1");
                        break;
                    case 2:
                        Console.WriteLine("Voce escolheu 2");
                        break;
                    case 3:
                        Console.WriteLine("Voce escolheu 3 saindo...");
                        flag = false;
                        break;
                }
            }
            */

            //vetor
            
            int[] vetor = new int[10];
            for (int i =0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um valor para Vetor[{0}]",i);
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nVetor (for()): ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("[{0}] ",vetor[i]);
            }


            Console.Write("\nVetor (foreach()): ");
            foreach(int item in vetor)
            {
                Console.Write("[{0}] ", item);
            }




            Console.ReadKey();
        }
    }
}
