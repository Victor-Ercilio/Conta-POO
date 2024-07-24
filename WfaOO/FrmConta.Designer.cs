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
            this.gpCadConta = new System.Windows.Forms.GroupBox();
            this.gpTransConta = new System.Windows.Forms.GroupBox();
            this.lstTrans = new System.Windows.Forms.ListBox();
            this.cmbTipoConta = new System.Windows.Forms.ComboBox();
            this.mskNroConta = new System.Windows.Forms.MaskedTextBox();
            this.nmrcLimiteConta = new System.Windows.Forms.NumericUpDown();
            this.txtSaldoConta = new System.Windows.Forms.TextBox();
            this.lblTrans = new System.Windows.Forms.Label();
            this.gpConta = new System.Windows.Forms.GroupBox();
            this.gpCadConta.SuspendLayout();
            this.gpTransConta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcLimiteConta)).BeginInit();
            this.gpConta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNroConta
            // 
            this.lblNroConta.AutoSize = true;
            this.lblNroConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroConta.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNroConta.Location = new System.Drawing.Point(15, 28);
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
            this.lblTitular.Location = new System.Drawing.Point(15, 79);
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
            this.lblLimiteConta.Location = new System.Drawing.Point(15, 132);
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
            this.lblTipoConta.Location = new System.Drawing.Point(109, 28);
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
            this.lblDispSaque.Location = new System.Drawing.Point(14, 21);
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
            this.lblValor.Location = new System.Drawing.Point(12, 18);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(39, 16);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarConta.Location = new System.Drawing.Point(129, 145);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(83, 26);
            this.btnCriarConta.TabIndex = 5;
            this.btnCriarConta.Text = "&Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(15, 43);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(83, 29);
            this.btnDepositar.TabIndex = 8;
            this.btnDepositar.Text = "&Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(129, 43);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(83, 29);
            this.btnSacar.TabIndex = 9;
            this.btnSacar.Text = "&Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // txtNroConta
            // 
            this.txtNroConta.Location = new System.Drawing.Point(459, 60);
            this.txtNroConta.Name = "txtNroConta";
            this.txtNroConta.Size = new System.Drawing.Size(83, 20);
            this.txtNroConta.TabIndex = 1;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(15, 98);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(197, 20);
            this.txtTitular.TabIndex = 3;
            // 
            // txtLimiteConta
            // 
            this.txtLimiteConta.Location = new System.Drawing.Point(459, 90);
            this.txtLimiteConta.Name = "txtLimiteConta";
            this.txtLimiteConta.Size = new System.Drawing.Size(100, 20);
            this.txtLimiteConta.TabIndex = 4;
            // 
            // txtTipoConta
            // 
            this.txtTipoConta.Location = new System.Drawing.Point(459, 34);
            this.txtTipoConta.Name = "txtTipoConta";
            this.txtTipoConta.Size = new System.Drawing.Size(100, 20);
            this.txtTipoConta.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(57, 17);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(155, 20);
            this.txtValor.TabIndex = 7;
            // 
            // lblSaldos
            // 
            this.lblSaldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaldos.Location = new System.Drawing.Point(459, 157);
            this.lblSaldos.Name = "lblSaldos";
            this.lblSaldos.Size = new System.Drawing.Size(139, 110);
            this.lblSaldos.TabIndex = 14;
            // 
            // gpCadConta
            // 
            this.gpCadConta.Controls.Add(this.lblNroConta);
            this.gpCadConta.Controls.Add(this.nmrcLimiteConta);
            this.gpCadConta.Controls.Add(this.txtTitular);
            this.gpCadConta.Controls.Add(this.cmbTipoConta);
            this.gpCadConta.Controls.Add(this.mskNroConta);
            this.gpCadConta.Controls.Add(this.lblTitular);
            this.gpCadConta.Controls.Add(this.lblTipoConta);
            this.gpCadConta.Controls.Add(this.btnCriarConta);
            this.gpCadConta.Controls.Add(this.lblLimiteConta);
            this.gpCadConta.Location = new System.Drawing.Point(12, 12);
            this.gpCadConta.Name = "gpCadConta";
            this.gpCadConta.Size = new System.Drawing.Size(224, 187);
            this.gpCadConta.TabIndex = 15;
            this.gpCadConta.TabStop = false;
            this.gpCadConta.Text = "Cadastro";
            // 
            // gpTransConta
            // 
            this.gpTransConta.Controls.Add(this.txtValor);
            this.gpTransConta.Controls.Add(this.lblValor);
            this.gpTransConta.Controls.Add(this.btnSacar);
            this.gpTransConta.Controls.Add(this.btnDepositar);
            this.gpTransConta.Enabled = false;
            this.gpTransConta.Location = new System.Drawing.Point(12, 215);
            this.gpTransConta.Name = "gpTransConta";
            this.gpTransConta.Size = new System.Drawing.Size(224, 88);
            this.gpTransConta.TabIndex = 16;
            this.gpTransConta.TabStop = false;
            this.gpTransConta.Text = "Transação";
            // 
            // lstTrans
            // 
            this.lstTrans.FormattingEnabled = true;
            this.lstTrans.Location = new System.Drawing.Point(17, 87);
            this.lstTrans.Name = "lstTrans";
            this.lstTrans.Size = new System.Drawing.Size(151, 186);
            this.lstTrans.TabIndex = 17;
            // 
            // cmbTipoConta
            // 
            this.cmbTipoConta.FormattingEnabled = true;
            this.cmbTipoConta.Items.AddRange(new object[] {
            "Comum",
            "Especial"});
            this.cmbTipoConta.Location = new System.Drawing.Point(112, 47);
            this.cmbTipoConta.Name = "cmbTipoConta";
            this.cmbTipoConta.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoConta.TabIndex = 18;
            this.cmbTipoConta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoConta_SelectedIndexChanged);
            // 
            // mskNroConta
            // 
            this.mskNroConta.Location = new System.Drawing.Point(18, 48);
            this.mskNroConta.Mask = "99990";
            this.mskNroConta.Name = "mskNroConta";
            this.mskNroConta.Size = new System.Drawing.Size(50, 20);
            this.mskNroConta.TabIndex = 19;
            this.mskNroConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmrcLimiteConta
            // 
            this.nmrcLimiteConta.Location = new System.Drawing.Point(15, 151);
            this.nmrcLimiteConta.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrcLimiteConta.Name = "nmrcLimiteConta";
            this.nmrcLimiteConta.Size = new System.Drawing.Size(99, 20);
            this.nmrcLimiteConta.TabIndex = 20;
            this.nmrcLimiteConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaldoConta
            // 
            this.txtSaldoConta.Location = new System.Drawing.Point(17, 40);
            this.txtSaldoConta.Name = "txtSaldoConta";
            this.txtSaldoConta.ReadOnly = true;
            this.txtSaldoConta.Size = new System.Drawing.Size(151, 20);
            this.txtSaldoConta.TabIndex = 2;
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrans.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTrans.Location = new System.Drawing.Point(14, 68);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(80, 16);
            this.lblTrans.TabIndex = 5;
            this.lblTrans.Text = "Transações";
            // 
            // gpConta
            // 
            this.gpConta.Controls.Add(this.lstTrans);
            this.gpConta.Controls.Add(this.lblTrans);
            this.gpConta.Controls.Add(this.txtSaldoConta);
            this.gpConta.Controls.Add(this.lblDispSaque);
            this.gpConta.Location = new System.Drawing.Point(252, 12);
            this.gpConta.Name = "gpConta";
            this.gpConta.Size = new System.Drawing.Size(191, 291);
            this.gpConta.TabIndex = 18;
            this.gpConta.TabStop = false;
            this.gpConta.Text = "Conta";
            // 
            // FrmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 310);
            this.Controls.Add(this.gpConta);
            this.Controls.Add(this.txtNroConta);
            this.Controls.Add(this.txtLimiteConta);
            this.Controls.Add(this.txtTipoConta);
            this.Controls.Add(this.gpTransConta);
            this.Controls.Add(this.gpCadConta);
            this.Controls.Add(this.lblSaldos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConta";
            this.Text = "Cadastro de Contas";
            this.gpCadConta.ResumeLayout(false);
            this.gpCadConta.PerformLayout();
            this.gpTransConta.ResumeLayout(false);
            this.gpTransConta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcLimiteConta)).EndInit();
            this.gpConta.ResumeLayout(false);
            this.gpConta.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpCadConta;
        private System.Windows.Forms.GroupBox gpTransConta;
        private System.Windows.Forms.ListBox lstTrans;
        private System.Windows.Forms.ComboBox cmbTipoConta;
        private System.Windows.Forms.MaskedTextBox mskNroConta;
        private System.Windows.Forms.NumericUpDown nmrcLimiteConta;
        private System.Windows.Forms.TextBox txtSaldoConta;
        private System.Windows.Forms.Label lblTrans;
        private System.Windows.Forms.GroupBox gpConta;
    }
}

