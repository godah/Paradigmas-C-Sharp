using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVS
{
    class Juridica : Conta
    {
        internal string cnpj { get; set; }

        internal Juridica()
        {
            this.cnpj = "0";
        }
    }
}
