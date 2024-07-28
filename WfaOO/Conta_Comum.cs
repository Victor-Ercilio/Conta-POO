using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaOO
{
    class Conta_Comum : Conta
    {
        public Conta_Comum() : base() { }
        {
            if(this.Conta_Saldo < valor)
            {
                throw new System.ArgumentException("Saldo Indisponível");
            }
            else
            {
                this.Conta_Saldo -= valor;
            }
        }
    }
}
