using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    //Herdando de Veiculos
    class Terrestre : Veiculo
    {
        //Construtor
        internal Terrestre()
        {
            combustivel = "Gasolina";
            velocidade = 120;
            qtdRodas = 4;
        }

        //Atributo exclusívo de Terrestre
        internal int qtdRodas { get; set; }

        //Implementando método abstrato de Veiculo
        internal override double ConsumoCombustivel()
        {
            //...calculos
            return 23412.12;
        }
    }
}
