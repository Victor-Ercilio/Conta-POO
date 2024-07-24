using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaOO
{
    public enum TipoConta
    {
        COMUM = 1,
        ESPECIAL
    }

    class Conta
    {
        public int Conta_Nro { get; set; }

        public double Conta_Saldo { get; protected set; }

        public double Conta_Limite { get; set; }

        public string Conta_Titular { get; set; }

        public int Conta_Tipo { get; set; }

        public virtual void Sacar(double valor)
        {
            
        }

        public void Depositar(double valor)
        {
            this.Conta_Saldo += valor;
        } 


    }
}
