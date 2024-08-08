namespace PClasses
{
    partial class frmMensalista
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
            this.btnInstanciar1 = new System.Windows.Forms.Button();
            this.btnInstanciar2 = new System.Windows.Forms.Button();
            this.lbnMatricula = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblSalarioMensal = new System.Windows.Forms.Label();
            this.lblDAtaENtradaEmpresa = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstanciar1
            // 
            this.btnInstanciar1.Location = new System.Drawing.Point(147, 354);
            this.btnInstanciar1.Name = "btnInstanciar1";
            this.btnInstanciar1.Size = new System.Drawing.Size(146, 94);
            this.btnInstanciar1.TabIndex = 0;
            this.btnInstanciar1.Text = "Instanciar Mensalista";
            this.btnInstanciar1.UseVisualStyleBackColor = true;
            this.btnInstanciar1.Click += new System.EventHandler(this.btnInstanciar1_Click);
            // 
            // btnInstanciar2
            // 
            this.btnInstanciar2.Location = new System.Drawing.Point(442, 354);
            this.btnInstanciar2.Name = "btnInstanciar2";
            this.btnInstanciar2.Size = new System.Drawing.Size(259, 94);
            this.btnInstanciar2.TabIndex = 1;
            this.btnInstanciar2.Text = "Instanciar Mensalista passando parâmetros";
            this.btnInstanciar2.UseVisualStyleBackColor = true;
            // 
            // lbnMatricula
            // 
            this.lbnMatricula.AutoSize = true;
            this.lbnMatricula.Location = new System.Drawing.Point(59, 58);
            this.lbnMatricula.Name = "lbnMatricula";
            this.lbnMatricula.Size = new System.Drawing.Size(100, 25);
            this.lbnMatricula.TabIndex = 2;
            this.lbnMatricula.Text = "Matricula";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(59, 151);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(68, 25);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Nome";
            // 
            // lblSalarioMensal
            // 
            this.lblSalarioMensal.AutoSize = true;
            this.lblSalarioMensal.Location = new System.Drawing.Point(59, 218);
            this.lblSalarioMensal.Name = "lblSalarioMensal";
            this.lblSalarioMensal.Size = new System.Drawing.Size(155, 25);
            this.lblSalarioMensal.TabIndex = 4;
            this.lblSalarioMensal.Text = "Salário Mensal";
            // 
            // lblDAtaENtradaEmpresa
            // 
            this.lblDAtaENtradaEmpresa.AutoSize = true;
            this.lblDAtaENtradaEmpresa.Location = new System.Drawing.Point(59, 289);
            this.lblDAtaENtradaEmpresa.Name = "lblDAtaENtradaEmpresa";
            this.lblDAtaENtradaEmpresa.Size = new System.Drawing.Size(259, 25);
            this.lblDAtaENtradaEmpresa.TabIndex = 5;
            this.lblDAtaENtradaEmpresa.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(175, 58);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(346, 31);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(331, 286);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(190, 31);
            this.txtDataEntrada.TabIndex = 7;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(227, 212);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(294, 31);
            this.txtSalario.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(175, 148);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(346, 31);
            this.txtNome.TabIndex = 9;
            // 
            // gbxHome
            // 
            this.gbxHome.Controls.Add(this.rbtnNao);
            this.gbxHome.Controls.Add(this.rbtnSim);
            this.gbxHome.Location = new System.Drawing.Point(608, 58);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(197, 185);
            this.gbxHome.TabIndex = 10;
            this.gbxHome.TabStop = false;
            this.gbxHome.Text = "Trabalha em Home Office";
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Checked = true;
            this.rbtnNao.Location = new System.Drawing.Point(17, 139);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(75, 29);
            this.rbtnNao.TabIndex = 1;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "NÃO";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(17, 104);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(67, 29);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.Text = "SIM";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PClasses.Properties.Resources.Pclasses1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 493);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDAtaENtradaEmpresa);
            this.Controls.Add(this.lblSalarioMensal);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbnMatricula);
            this.Controls.Add(this.btnInstanciar2);
            this.Controls.Add(this.btnInstanciar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstanciar1;
        private System.Windows.Forms.Button btnInstanciar2;
        private System.Windows.Forms.Label lbnMatricula;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblSalarioMensal;
        private System.Windows.Forms.Label lblDAtaENtradaEmpresa;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
    }
}