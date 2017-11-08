using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    //Herdando de Veiculo
    class Naval : Veiculo
    {
        //Construtor
        internal Naval()
        {
            combustivel = "Diesel";
            velocidade = 70;
            qtdSalvaVidas = 18;
        }

        //Atributo exclusívo de Naval
        internal int qtdSalvaVidas { get; set; }

        //Implementando método abstrato de Veiculo
        internal override double ConsumoCombustivel()
        {
            //...calculos
            return 342.234;
        }
    }
}
