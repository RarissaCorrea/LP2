namespace Psalario
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.cmbNumFilhos = new System.Windows.Forms.ComboBox();
            this.btnVerificaDesconto = new System.Windows.Forms.Button();
            this.lblDados = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.pnlCasado = new System.Windows.Forms.Panel();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.msktbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.lblIRRF = new System.Windows.Forms.Label();
            this.txtIRRF = new System.Windows.Forms.TextBox();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.lblDescIRFF = new System.Windows.Forms.Label();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.txtDescINSS = new System.Windows.Forms.TextBox();
            this.gbxSexo.SuspendLayout();
            this.pnlCasado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFunc.Location = new System.Drawing.Point(34, 47);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(180, 25);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome funcionário";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.Location = new System.Drawing.Point(34, 94);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(124, 25);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Slário Bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFilhos.Location = new System.Drawing.Point(34, 142);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(174, 25);
            this.lblNumFilhos.TabIndex = 2;
            this.lblNumFilhos.Text = "Número de filhos";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(249, 52);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(269, 31);
            this.txtNomeFunc.TabIndex = 3;
            // 
            // cmbNumFilhos
            // 
            this.cmbNumFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumFilhos.FormattingEnabled = true;
            this.cmbNumFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbNumFilhos.Location = new System.Drawing.Point(249, 142);
            this.cmbNumFilhos.Name = "cmbNumFilhos";
            this.cmbNumFilhos.Size = new System.Drawing.Size(269, 33);
            this.cmbNumFilhos.TabIndex = 6;
            // 
            // btnVerificaDesconto
            // 
            this.btnVerificaDesconto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerificaDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificaDesconto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerificaDesconto.Location = new System.Drawing.Point(249, 224);
            this.btnVerificaDesconto.Name = "btnVerificaDesconto";
            this.btnVerificaDesconto.Size = new System.Drawing.Size(242, 41);
            this.btnVerificaDesconto.TabIndex = 7;
            this.btnVerificaDesconto.Text = "Verifica Desconto";
            this.btnVerificaDesconto.UseVisualStyleBackColor = false;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.Location = new System.Drawing.Point(36, 286);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(96, 25);
            this.lblDados.TabIndex = 8;
            this.lblDados.Text = "lblDados";
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasc);
            this.gbxSexo.Controls.Add(this.rbtnFem);
            this.gbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(674, 52);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(316, 99);
            this.gbxSexo.TabIndex = 9;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(21, 55);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(48, 29);
            this.rbtnMasc.TabIndex = 1;
            this.rbtnMasc.Text = "M";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Checked = true;
            this.rbtnFem.Location = new System.Drawing.Point(21, 20);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(43, 29);
            this.rbtnFem.TabIndex = 0;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "F";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // pnlCasado
            // 
            this.pnlCasado.Controls.Add(this.ckbxCasado);
            this.pnlCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCasado.Location = new System.Drawing.Point(674, 166);
            this.pnlCasado.Name = "pnlCasado";
            this.pnlCasado.Size = new System.Drawing.Size(316, 99);
            this.pnlCasado.TabIndex = 10;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(76, 32);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(105, 29);
            this.ckbxCasado.TabIndex = 0;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // msktbxSalarioBruto
            // 
            this.msktbxSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktbxSalarioBruto.Location = new System.Drawing.Point(249, 98);
            this.msktbxSalarioBruto.Mask = "9990.00";
            this.msktbxSalarioBruto.Name = "msktbxSalarioBruto";
            this.msktbxSalarioBruto.Size = new System.Drawing.Size(269, 31);
            this.msktbxSalarioBruto.TabIndex = 11;
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliquotaINSS.Location = new System.Drawing.Point(41, 343);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(144, 25);
            this.lblAliquotaINSS.TabIndex = 12;
            this.lblAliquotaINSS.Text = "Aliquota INSS";
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquotaINSS.Location = new System.Drawing.Point(200, 337);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(318, 31);
            this.txtAliquotaINSS.TabIndex = 13;
            // 
            // lblIRRF
            // 
            this.lblIRRF.AutoSize = true;
            this.lblIRRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIRRF.Location = new System.Drawing.Point(41, 403);
            this.lblIRRF.Name = "lblIRRF";
            this.lblIRRF.Size = new System.Drawing.Size(144, 25);
            this.lblIRRF.TabIndex = 14;
            this.lblIRRF.Text = "Aliquota IRRF";
            // 
            // txtIRRF
            // 
            this.txtIRRF.Enabled = false;
            this.txtIRRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIRRF.Location = new System.Drawing.Point(200, 397);
            this.txtIRRF.Name = "txtIRRF";
            this.txtIRRF.Size = new System.Drawing.Size(318, 31);
            this.txtIRRF.TabIndex = 15;
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalFamilia.Location = new System.Drawing.Point(40, 483);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(154, 25);
            this.lblSalFamilia.TabIndex = 16;
            this.lblSalFamilia.Text = "Salário Familia";
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Enabled = false;
            this.txtSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalLiquido.Location = new System.Drawing.Point(200, 558);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(318, 31);
            this.txtSalLiquido.TabIndex = 17;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalFamilia.Location = new System.Drawing.Point(200, 477);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(318, 31);
            this.txtSalFamilia.TabIndex = 18;
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalLiquido.Location = new System.Drawing.Point(41, 564);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(155, 25);
            this.lblSalLiquido.TabIndex = 19;
            this.lblSalLiquido.Text = "Salário Liquido";
            // 
            // lblDescIRFF
            // 
            this.lblDescIRFF.AutoSize = true;
            this.lblDescIRFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescIRFF.Location = new System.Drawing.Point(559, 403);
            this.lblDescIRFF.Name = "lblDescIRFF";
            this.lblDescIRFF.Size = new System.Drawing.Size(154, 25);
            this.lblDescIRFF.TabIndex = 20;
            this.lblDescIRFF.Text = "Salário Familia";
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescINSS.Location = new System.Drawing.Point(556, 346);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(157, 25);
            this.lblDescINSS.TabIndex = 21;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Enabled = false;
            this.txtDescINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescINSS.Location = new System.Drawing.Point(719, 343);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.Size = new System.Drawing.Size(318, 31);
            this.txtDescINSS.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 661);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.lblDescIRFF);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.txtIRRF);
            this.Controls.Add(this.lblIRRF);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.msktbxSalarioBruto);
            this.Controls.Add(this.pnlCasado);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.btnVerificaDesconto);
            this.Controls.Add(this.cmbNumFilhos);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNomeFunc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.pnlCasado.ResumeLayout(false);
            this.pnlCasado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.ComboBox cmbNumFilhos;
        private System.Windows.Forms.Button btnVerificaDesconto;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.Panel pnlCasado;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.MaskedTextBox msktbxSalarioBruto;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.Label lblIRRF;
        private System.Windows.Forms.TextBox txtIRRF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.Label lblDescIRFF;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.TextBox txtDescINSS;
    }
}

