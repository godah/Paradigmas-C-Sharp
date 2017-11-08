using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    //classe abstrata impondo a implementação do metodo [internal double ConsumoCombustivel()]
    abstract class Veiculo
    {
        internal int velocidade { get; set; }
        internal string combustivel { get; set; }
        //método abstrato
        internal abstract double ConsumoCombustivel();
    }
}
