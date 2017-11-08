using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVS
{
    class Fisica : Conta
    {
        internal string cpf { get; set; }

        internal Fisica()
        {
            this.cpf = "0";
        }

        public static implicit operator List<object>(Fisica v)
        {
            throw new NotImplementedException();
        }
    }
}
