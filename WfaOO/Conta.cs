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

    abstract class Conta
    {

        protected Conta() 
        {
            Numero = 1;
            Saldo = 0.0m;
            Limite = 0.0m;
            Titular = "";
        }

        public int Numero { get; set; }

        public decimal Saldo { get; protected set; }

        public decimal Limite { get; set; }

        public string Titular { get; set; }

        public virtual void Sacar(decimal valor)
        {
            
        }

        public void Depositar(decimal valor)
        {
            if (valor < 0)
                this.Saldo += valor;
            else
                throw new ArgumentException("Valor para depósito não pode ser negativo");
        } 


    }
}
