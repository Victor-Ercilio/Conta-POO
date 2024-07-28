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

        public override void Sacar(decimal valor)
        {
            if(this.Saldo < valor)
            {
                throw new System.ArgumentException("Saldo Indisponível");
            }
            else
            {
                this.Saldo -= valor;
            }
        }
    }
}
