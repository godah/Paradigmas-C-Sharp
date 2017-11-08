using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //herança simples
            Console.WriteLine("Herança Simples Aereo");
            Aereo a = new Aereo();
            Console.WriteLine("Combustivel: {0}, Velocidade: {1}, Consumo: {2}, Qtd. de Asas: {3}.", a.combustivel, a.velocidade, a.ConsumoCombustivel(), a.qtdAsas);

            Console.WriteLine("\nHerança Simples Naval");
            Naval n = new Naval();
            Console.WriteLine("Combustivel: {0}, Velocidade: {1}, Consumo: {2}, Qtd. de Salva-Vidas: {3}.", n.combustivel, n.velocidade, n.ConsumoCombustivel(), n.qtdSalvaVidas);


            Console.WriteLine("\nHerança Simples Terrestre");
            Terrestre t = new Terrestre();
            Console.WriteLine("Combustivel: {0}, Velocidade: {1}, Consumo: {2}, Qtd. de Asas: {3}.", t.combustivel, t.velocidade, t.ConsumoCombustivel(), t.qtdRodas);



            //Polimorfismo com atributo especifico utilizando typecast para acesso
            //Observe que o objeto v do tipo Veiculo recebe objetos filhos (Aereo, Naval, Terrestre)
            Veiculo v;

            Console.WriteLine("\nPolimorfismo Aereo");
            v = new Aereo();
            Console.WriteLine("Combustivel: {0}, Velocidade: {1}, Consumo: {2}, Qtd. de Asas: {3}.", v.combustivel, v.velocidade, v.ConsumoCombustivel(), ((Aereo)v).qtdAsas);//typecast Aereo

            Console.WriteLine("\nPolimorfismo Naval");
            v = new Naval();
            Console.WriteLine("Combustivel: {0}, Velocidade: {1}, Consumo: {2}, Qtd. de Asas: {3}.", v.combustivel, v.velocidade, v.ConsumoCombustivel(), ((Naval)v).qtdSalvaVidas);//typecast Naval


            Console.WriteLine("\nPolimorfismo Terrestre");
            v = new Terrestre();
            Console.WriteLine("Combustivel: {0}, Velocidade: {1}, Consumo: {2}, Qtd. de Asas: {3}.", v.combustivel, v.velocidade, v.ConsumoCombustivel(), ((Terrestre)v).qtdRodas);//typecast Terrestre
            


            //Criando uma Lista de Veiculos Generica utilizando polimofismo
            //neste caso o uso do typecast para acessar os atributos exclusivos se torna nao viavel pela lista ser dinamica
            //no entanto podemos tratar com objeto.GetType()
            List<Veiculo> list = new List<Veiculo>();
            list.Add(new Aereo());
            list.Add(new Naval());
            list.Add(new Terrestre());
            list.Add(new Naval());
            list.Add(new Terrestre());
            list.Add(new Aereo());
            list.Add(new Naval());
            list.Add(new Terrestre());
            list.Add(new Aereo());
            list.Add(new Aereo());
            list.Add(new Terrestre());
            list.Add(new Aereo());
            list.Add(new Terrestre());
            list.Add(new Terrestre());

            foreach (var veiculo in list)
            {
                int tipo;
                if (veiculo.GetType() == typeof(Aereo))
                    tipo = 1;

                else if (veiculo.GetType() == typeof(Naval))
                    tipo = 2;

                else if (veiculo.GetType() == typeof(Terrestre))
                    tipo = 3;

                else
                    tipo = 0;
                switch (tipo)
                {
                    case 1://Aereo
                        Console.WriteLine("Tipo: {4}, Comb: {0}, Vel: {1}, Consumo: {2}, Qtd. Asas: {3}.", veiculo.combustivel, veiculo.velocidade, veiculo.ConsumoCombustivel(), ((Aereo)veiculo).qtdAsas, veiculo.GetType().Name);//typecast Aereo
                        break;

                    case 2://Naval
                        Console.WriteLine("Tipo: {4}, Comb: {0}, Vel: {1}, Consumo: {2}, Qtd. Salva-Vidas: {3}.", veiculo.combustivel, veiculo.velocidade, veiculo.ConsumoCombustivel(), ((Naval)veiculo).qtdSalvaVidas, veiculo.GetType().Name);//typecast Naval
                        break;

                    case 3://Terrestre
                        Console.WriteLine("Tipo: {4}, Comb: {0}, Vel: {1}, Consumo: {2}, Qtd. Rodas: {3}.", veiculo.combustivel, veiculo.velocidade, veiculo.ConsumoCombustivel(), ((Terrestre)veiculo).qtdRodas, veiculo.GetType().Name);//typecast Terrestre
                        break;

                    default:
                        break;
                }
             
            }


            Console.ReadKey();
        }
    }
}

