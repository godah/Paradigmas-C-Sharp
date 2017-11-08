using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    //Herdando de Veiculo
    class Aereo : Veiculo
    {
        //Construtor
        internal Aereo()
        {
            combustivel = "Shell";
            velocidade = 400;
            qtdAsas = 2;
        }

        //Atributo exclusívo de Aereo
        internal int qtdAsas { get; set; }

        //Implementando metodo abstrato de Veiculo
        internal override double ConsumoCombustivel()
        {
            //...calculos
            return 43.2;
        }
    }
}
