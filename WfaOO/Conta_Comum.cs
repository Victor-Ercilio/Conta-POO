using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaOO
{
    class Conta_Comum : Conta
    {
        /* REF PART2
        public int Conta_Nro { get; set; }
        public double Conta_Saldo { get; private set; }
        public double Conta_Limite { get; set; }
        public string Conta_Titular { get; set; }
        public int Conta_Tipo { get; set; }*/

        public override void Sacar(double valor)
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

        /* REF PART2
        public void Depositar(double valor)
        {
            this.Conta_Saldo += valor;
        }*/
    }
}
