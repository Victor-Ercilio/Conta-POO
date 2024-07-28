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
        private readonly Conta_Comum contaComum;
        private readonly Conta_Especial contaEspecial;

        public FrmConta()
        {
            InitializeComponent();
            contaComum = new Conta_Comum();
            contaEspecial = new Conta_Especial();
            gpTransConta.Enabled = false;
        }

        private TipoConta TipoConta {  get; set; }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            if(cmbTipoConta.SelectedIndex == -1)
            {
                gpTransConta.Enabled = false;
                return;
            }

            lstTrans.Items.Clear();

            if (cmbTipoConta.SelectedItem.ToString() == "Comum")
            {
                contaComum.Numero = int.Parse(mskNroConta.Text);
                contaComum.Titular = txtTitular.Text;
                TipoConta = TipoConta.COMUM;
                
                txtSaldoConta.Text = $"{contaComum.Saldo:C2}";
            }
            else
            {
                contaEspecial.Numero = int.Parse(mskNroConta.Text);
                contaEspecial.Titular = txtTitular.Text;
                contaEspecial.Limite = nmrcLimiteConta.Value;
                TipoConta = TipoConta.ESPECIAL;

                txtSaldoConta.Text = $"{(contaEspecial.Saldo + contaEspecial.Limite):C2}";
            }

            gpTransConta.Enabled = true;
            
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtValor.Text, out decimal valor))
                return;

            if(valor  < 0) return;

            if(TipoConta == TipoConta.COMUM)
            {
                contaComum.Depositar(valor);
                txtSaldoConta.Text = $"{contaComum.Saldo:C2}";
            }
            else
            {
                contaEspecial.Depositar(valor);
                txtSaldoConta.Text = $"{(contaEspecial.Saldo + contaEspecial.Limite):C2}";
            }

            lstTrans.Items.Insert(0, $" + {valor:C2}");
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!decimal.TryParse(txtValor.Text, out decimal valor))
                    return;
                
                if (valor < 0) return;

                if (TipoConta == TipoConta.COMUM)
                {
                    contaComum.Sacar(valor);
                    txtSaldoConta.Text = $"{contaComum.Saldo:C2}";
                }
                else
                {
                    contaEspecial.Sacar(valor);
                    txtSaldoConta.Text = $"{(contaEspecial.Saldo + contaEspecial.Limite):C2}"; ;
                }

                lstTrans.Items.Insert(0, $" - {valor:C2}");
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