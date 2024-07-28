using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaOO
{
    class Conta_Especial : Conta
    {
        public Conta_Especial() : base() { }

        public override void Sacar(decimal valor)
        {
            if(this.Saldo + this.Limite < valor)
            {
                throw new System.ArgumentException("Saldo Indisponível");
            }
            else
            {
                if(this.Saldo > valor)
                {
                    this.Saldo -= valor;
                }
                else
                {
                    decimal saldo_dif = valor - this.Saldo;
                    this.Saldo = 0;
                    this.Limite -= saldo_dif;
                }
            }
        }
    }
}
