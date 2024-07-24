using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaOO
{
    public partial class FrmConta : Form
    {
        private Conta_Comum contaComum;
        private Conta_Especial contaEspecial;

        public FrmConta()
        {
            InitializeComponent();
            contaComum = new Conta_Comum();
            contaEspecial = new Conta_Especial();
            gpTransConta.Enabled = false;
        }

        Conta_Comum conta_Comum = new Conta_Comum();
        Conta_Especial conta_Especial = new Conta_Especial();
        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            if(cmbTipoConta.SelectedIndex == -1)
            {
                gpTransConta.Enabled = false;
                return;
            }

            lblSaldos.Text = "";

            if(cmbTipoConta.SelectedItem.ToString() == "Comum")
            {
                contaComum.Conta_Nro = int.Parse(mskNroConta.Text);
                contaComum.Conta_Titular = txtTitular.Text;
                contaComum.Conta_Limite = 0;
                contaComum.Conta_Tipo = 1;
                
                txtSaldoConta.Text = $"{contaComum.Conta_Saldo:C2}";
            }
            else
            {
                contaEspecial.Conta_Nro = int.Parse(mskNroConta.Text);
                contaEspecial.Conta_Titular = txtTitular.Text;
                contaEspecial.Conta_Limite = (int) nmrcLimiteConta.Value;
                contaEspecial.Conta_Tipo = 2;

                txtSaldoConta.Text = $"{contaComum.Conta_Saldo:C2}";
            }

            gpTransConta.Enabled = true;
            /*
            if (int.Parse(txtTipoConta.Text) == 1)
            {
                conta_Comum.Conta_Nro = int.Parse(txtNroConta.Text);
                conta_Comum.Conta_Titular = txtTitular.Text;
                conta_Comum.Conta_Tipo = int.Parse(txtTipoConta.Text);
                conta_Comum.Conta_Limite = 0;
                lblSaldos.Text += "Conta Comum\n";
                lblSaldos.Text += "Saldo = " + conta_Comum.Conta_Saldo + "\n";
                lblSaldos.Text += "Limite = " + conta_Comum.Conta_Limite + "\n";
            }
            else
            {
                conta_Especial.Conta_Nro = int.Parse(txtNroConta.Text);
                conta_Especial.Conta_Titular = txtTitular.Text;
                conta_Especial.Conta_Tipo = int.Parse(txtTipoConta.Text);
                conta_Especial.Conta_Limite = double.Parse(txtLimiteConta.Text);
                lblSaldos.Text += "Conta Especial\n";
                lblSaldos.Text += "Saldo = " + conta_Especial.Conta_Saldo + "\n";
                lblSaldos.Text += "Limite = " + conta_Especial.Conta_Limite + "\n";
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

            if (int.Parse(txtTipoConta.Text) == 1)
            {
                conta_Comum.Depositar(double.Parse(txtValor.Text));
                lblSaldos.Text += "Saldo = " + conta_Comum.Conta_Saldo + "\n";
                lblSaldos.Text += "Limite = " + conta_Comum.Conta_Limite + "\n";
            }
            else
            {
                conta_Especial.Depositar(double.Parse(txtValor.Text));
                lblSaldos.Text += "Saldo = " + conta_Especial.Conta_Saldo + "\n";
                lblSaldos.Text += "Limite = " + conta_Especial.Conta_Limite + "\n";
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {

            try
            {

                if (int.Parse(txtTipoConta.Text) == 1)
                {
                    conta_Comum.Sacar(double.Parse(txtValor.Text));
                    lblSaldos.Text += "Saldo = " + conta_Comum.Conta_Saldo + "\n";
                    lblSaldos.Text += "Limite = " + conta_Comum.Conta_Limite + "\n";
                }
                else
                {
                    conta_Especial.Sacar(double.Parse(txtValor.Text));
                    lblSaldos.Text += "Saldo = " + conta_Especial.Conta_Saldo + "\n";
                    lblSaldos.Text += "Limite = " + conta_Especial.Conta_Limite + "\n";
                }
            }
            catch (System.ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
    }
}
