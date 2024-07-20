namespace WfaOO
{
    partial class FrmConta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConta));
            this.lblNroConta = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblLimiteConta = new System.Windows.Forms.Label();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.lblDispSaque = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.txtNroConta = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtLimiteConta = new System.Windows.Forms.TextBox();
            this.txtTipoConta = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblSaldos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNroConta
            // 
            this.lblNroConta.AutoSize = true;
            this.lblNroConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroConta.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNroConta.Location = new System.Drawing.Point(35, 38);
            this.lblNroConta.Name = "lblNroConta";
            this.lblNroConta.Size = new System.Drawing.Size(86, 16);
            this.lblNroConta.TabIndex = 0;
            this.lblNroConta.Text = "Nro da Conta";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitular.Location = new System.Drawing.Point(164, 38);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(44, 16);
            this.lblTitular.TabIndex = 1;
            this.lblTitular.Text = "Titular";
            // 
            // lblLimiteConta
            // 
            this.lblLimiteConta.AutoSize = true;
            this.lblLimiteConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimiteConta.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLimiteConta.Location = new System.Drawing.Point(445, 38);
            this.lblLimiteConta.Name = "lblLimiteConta";
            this.lblLimiteConta.Size = new System.Drawing.Size(99, 16);
            this.lblLimiteConta.TabIndex = 3;
            this.lblLimiteConta.Text = "Limite da Conta";
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConta.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTipoConta.Location = new System.Drawing.Point(303, 38);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(92, 16);
            this.lblTipoConta.TabIndex = 2;
            this.lblTipoConta.Text = "Tipo da Conta";
            // 
            // lblDispSaque
            // 
            this.lblDispSaque.AutoSize = true;
            this.lblDispSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispSaque.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDispSaque.Location = new System.Drawing.Point(35, 149);
            this.lblDispSaque.Name = "lblDispSaque";
            this.lblDispSaque.Size = new System.Drawing.Size(143, 16);
            this.lblDispSaque.TabIndex = 5;
            this.lblDispSaque.Text = "Disponível para saque";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblValor.Location = new System.Drawing.Point(303, 95);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(39, 16);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarConta.Location = new System.Drawing.Point(564, 51);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(83, 26);
            this.btnCriarConta.TabIndex = 6;
            this.btnCriarConta.Text = "&Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(448, 105);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(83, 29);
            this.btnDepositar.TabIndex = 7;
            this.btnDepositar.Text = "&Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(564, 105);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(83, 29);
            this.btnSacar.TabIndex = 8;
            this.btnSacar.Text = "&Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // txtNroConta
            // 
            this.txtNroConta.Location = new System.Drawing.Point(38, 57);
            this.txtNroConta.Name = "txtNroConta";
            this.txtNroConta.Size = new System.Drawing.Size(100, 20);
            this.txtNroConta.TabIndex = 9;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(167, 57);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(100, 20);
            this.txtTitular.TabIndex = 10;
            // 
            // txtLimiteConta
            // 
            this.txtLimiteConta.Location = new System.Drawing.Point(448, 57);
            this.txtLimiteConta.Name = "txtLimiteConta";
            this.txtLimiteConta.Size = new System.Drawing.Size(100, 20);
            this.txtLimiteConta.TabIndex = 12;
            // 
            // txtTipoConta
            // 
            this.txtTipoConta.Location = new System.Drawing.Point(306, 57);
            this.txtTipoConta.Name = "txtTipoConta";
            this.txtTipoConta.Size = new System.Drawing.Size(100, 20);
            this.txtTipoConta.TabIndex = 11;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(306, 114);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 13;
            // 
            // lblSaldos
            // 
            this.lblSaldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldos.Location = new System.Drawing.Point(38, 176);
            this.lblSaldos.Name = "lblSaldos";
            this.lblSaldos.Size = new System.Drawing.Size(609, 145);
            this.lblSaldos.TabIndex = 14;
            // 
            // FrmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 330);
            this.Controls.Add(this.lblSaldos);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtLimiteConta);
            this.Controls.Add(this.txtTipoConta);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.txtNroConta);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.lblDispSaque);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblLimiteConta);
            this.Controls.Add(this.lblTipoConta);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.lblNroConta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConta";
            this.Text = "Cadastro de Contas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroConta;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblLimiteConta;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.Label lblDispSaque;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.TextBox txtNroConta;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtLimiteConta;
        private System.Windows.Forms.TextBox txtTipoConta;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblSaldos;
    }
}

