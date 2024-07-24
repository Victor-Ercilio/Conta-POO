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

        private TipoConta TipoConta {  get; set; }

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
            lstTrans.Items.Clear();

            if (cmbTipoConta.SelectedItem.ToString() == "Comum")
            {
                contaComum.Conta_Nro = int.Parse(mskNroConta.Text);
                contaComum.Conta_Titular = txtTitular.Text;
                contaComum.Conta_Limite = 0;
                contaComum.Conta_Tipo = 1;
                TipoConta = TipoConta.COMUM;
                
                txtSaldoConta.Text = $"{contaComum.Conta_Saldo:C2}";
            }
            else
            {
                contaEspecial.Conta_Nro = int.Parse(mskNroConta.Text);
                contaEspecial.Conta_Titular = txtTitular.Text;
                contaEspecial.Conta_Limite = (int) nmrcLimiteConta.Value;
                contaEspecial.Conta_Tipo = 2;
                TipoConta = TipoConta.ESPECIAL;

                txtSaldoConta.Text = $"{(contaEspecial.Conta_Saldo + contaEspecial.Conta_Limite):C2}";
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

                lstTrans.Items.Add($"Saldo = {conta_Comum.Conta_Saldo}\t");
                lstTrans.Items.Add($"Limite = {conta_Comum.Conta_Limite}\n");
            }
            else
            {
                conta_Especial.Conta_Nro = int.Parse(txtNroConta.Text);
                conta_Especial.Conta_Titular = txtTitular.Text;
                conta_Especial.Conta_Tipo = int.Parse(txtTipoConta.Text);
                conta_Especial.Conta_Limite = double.Parse(txtLimiteConta.Text);
                lblSaldos.Text += $"Conta Especial {lstTrans.Items.Count}\n";
                lblSaldos.Text += "Saldo = " + conta_Especial.Conta_Saldo + "\n";
                lblSaldos.Text += "Limite = " + conta_Especial.Conta_Limite + "\n";

                lstTrans.Items.Add(
                    $"Saldo = {conta_Especial.Conta_Saldo}\t" + 
                    $"Limite = {conta_Especial.Conta_Limite}\n");
            }*/
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtValor.Text, out double valor))
                return;

            if(valor  < 0) return;

            if(TipoConta == TipoConta.COMUM)
            {
                contaComum.Depositar(valor);
                txtSaldoConta.Text = $"{contaComum.Conta_Saldo:C2}";
            }
            else
            {
                contaEspecial.Depositar(valor);
                txtSaldoConta.Text = $"{(contaEspecial.Conta_Saldo + contaEspecial.Conta_Limite):C2}";
            }

            lstTrans.Items.Insert(0, $" + {valor:C2}");
            /*
            if (int.Parse(txtTipoConta.Text) == 1)
            {
                conta_Comum.Depositar(double.Parse(txtValor.Text));
                lblSaldos.Text += "Saldo = " + conta_Comum.Conta_Saldo + "\n";
                lblSaldos.Text += "Limite = " + conta_Comum.Conta_Limite + "\n";
                
                lstTrans.Items.Add($"Saldo = {conta_Comum.Conta_Saldo}\t");
                lstTrans.Items.Add($"Limite = {conta_Comum.Conta_Limite}\n");
            }
            else
            {
                conta_Especial.Depositar(double.Parse(txtValor.Text));
                lblSaldos.Text += "Saldo = " + conta_Especial.Conta_Saldo + "\n";
                lblSaldos.Text += "Limite = " + conta_Especial.Conta_Limite + "\n";

                lstTrans.Items.Add(
                    $"Saldo = {conta_Especial.Conta_Saldo}\t" +
                    $"Limite = {conta_Especial.Conta_Limite}\n");
                
            }*/
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!double.TryParse(txtValor.Text, out double valor))
                    return;
                
                if (valor < 0) return;

                if (TipoConta == TipoConta.COMUM)
                {
                    contaComum.Sacar(valor);
                    txtSaldoConta.Text = $"{contaComum.Conta_Saldo:C2}";
                }
                else
                {
                    contaEspecial.Sacar(valor);
                    txtSaldoConta.Text = $"{(contaEspecial.Conta_Saldo + contaEspecial.Conta_Limite):C2}"; ;
                }

                lstTrans.Items.Insert(0, $" - {valor:C2}");
                /*
                if (int.Parse(txtTipoConta.Text) == 1)
                {
                    conta_Comum.Sacar(double.Parse(txtValor.Text));
                    lblSaldos.Text += "Saldo = " + conta_Comum.Conta_Saldo + "\n";
                    lblSaldos.Text += "Limite = " + conta_Comum.Conta_Limite + "\n";

                    lstTrans.Items.Add($"Saldo = {conta_Comum.Conta_Saldo}\t");
                    lstTrans.Items.Add($"Limite = {conta_Comum.Conta_Limite}\n");
                }
                else
                {
                    conta_Especial.Sacar(double.Parse(txtValor.Text));
                    lblSaldos.Text += "Saldo = " + conta_Especial.Conta_Saldo + "\n";
                    lblSaldos.Text += "Limite = " + conta_Especial.Conta_Limite + "\n";

                    lstTrans.Items.Add(
                        $"Saldo = {conta_Especial.Conta_Saldo}\t" +
                        $"Limite = {conta_Especial.Conta_Limite}\n");
                }*/
            }
            catch (System.ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void cmbTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbTipoConta.SelectedIndex;
            int naoSelecionado = -1;
            int contaComumSelecionado = 0;

            if (selectedIndex == naoSelecionado || selectedIndex == contaComumSelecionado)
                nmrcLimiteConta.Enabled = false;
            else
                nmrcLimiteConta.Enabled = true;
        }
    }
}