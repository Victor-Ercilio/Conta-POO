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
        {
            if(this.Conta_Saldo + this.Conta_Limite < valor)
            {
                throw new System.ArgumentException("Saldo Indisponível");
            }
            else
            {
                double saldo_dif = this.Conta_Saldo + this.Conta_Limite;
                if(this.Conta_Saldo > valor)
                {
                    this.Conta_Saldo -= valor;
                }
                else
                {
                    saldo_dif = valor - this.Conta_Saldo;
                    this.Conta_Saldo = 0;
                    this.Conta_Limite -= saldo_dif;
                }
            }
        }
    }
}
