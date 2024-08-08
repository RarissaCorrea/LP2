namespace PClasses
{
    partial class frmHorista
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
            this.gbxHome = new System.Windows.Forms.GroupBox();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumHoras = new System.Windows.Forms.TextBox();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblDAtaENtradaEmpresa = new System.Windows.Forms.Label();
            this.lblNumHoras = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbnMatricula = new System.Windows.Forms.Label();
            this.btnInstanciarHorista = new System.Windows.Forms.Button();
            this.lblSalarioHora = new System.Windows.Forms.Label();
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.txtDiasFalta = new System.Windows.Forms.TextBox();
            this.lblDiasFaltas = new System.Windows.Forms.Label();
            this.gbxHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHome
            // 
            this.gbxHome.Controls.Add(this.rbtnNao);
            this.gbxHome.Controls.Add(this.rbtnSim);
            this.gbxHome.Location = new System.Drawing.Point(590, 52);
            this.gbxHome.Name = "gbxHome";
            this.gbxHome.Size = new System.Drawing.Size(204, 185);
            this.gbxHome.TabIndex = 21;
            this.gbxHome.TabStop = false;
            this.gbxHome.Text = "Trabalha em Home Office";
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(17, 139);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(75, 29);
            this.rbtnNao.TabIndex = 1;
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(157, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(353, 31);
            this.txtNome.TabIndex = 20;
            // 
            // txtNumHoras
            // 
            this.txtNumHoras.Location = new System.Drawing.Point(209, 163);
            this.txtNumHoras.Name = "txtNumHoras";
            this.txtNumHoras.Size = new System.Drawing.Size(301, 31);
            this.txtNumHoras.TabIndex = 19;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(313, 200);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(197, 31);
            this.txtDataEntrada.TabIndex = 18;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(157, 52);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(353, 31);
            this.txtMatricula.TabIndex = 17;
            // 
            // lblDAtaENtradaEmpresa
            // 
            this.lblDAtaENtradaEmpresa.AutoSize = true;
            this.lblDAtaENtradaEmpresa.Location = new System.Drawing.Point(48, 203);
            this.lblDAtaENtradaEmpresa.Name = "lblDAtaENtradaEmpresa";
            this.lblDAtaENtradaEmpresa.Size = new System.Drawing.Size(259, 25);
            this.lblDAtaENtradaEmpresa.TabIndex = 16;
            this.lblDAtaENtradaEmpresa.Text = "Data Entrada na Empresa";
            // 
            // lblNumHoras
            // 
            this.lblNumHoras.AutoSize = true;
            this.lblNumHoras.Location = new System.Drawing.Point(48, 163);
            this.lblNumHoras.Name = "lblNumHoras";
            this.lblNumHoras.Size = new System.Drawing.Size(113, 25);
            this.lblNumHoras.TabIndex = 15;
            this.lblNumHoras.Text = "NumHoras";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(48, 89);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(68, 25);
            this.lbl.TabIndex = 14;
            this.lbl.Text = "Nome";
            // 
            // lbnMatricula
            // 
            this.lbnMatricula.AutoSize = true;
            this.lbnMatricula.Location = new System.Drawing.Point(48, 52);
            this.lbnMatricula.Name = "lbnMatricula";
            this.lbnMatricula.Size = new System.Drawing.Size(100, 25);
            this.lbnMatricula.TabIndex = 13;
            this.lbnMatricula.Text = "Matricula";
            // 
            // btnInstanciarHorista
            // 
            this.btnInstanciarHorista.Location = new System.Drawing.Point(357, 354);
            this.btnInstanciarHorista.Name = "btnInstanciarHorista";
            this.btnInstanciarHorista.Size = new System.Drawing.Size(153, 94);
            this.btnInstanciarHorista.TabIndex = 11;
            this.btnInstanciarHorista.Text = "Instanciar Horista";
            this.btnInstanciarHorista.UseVisualStyleBackColor = true;
            this.btnInstanciarHorista.Click += new System.EventHandler(this.btnInstanciarHorista_Click);
            // 
            // lblSalarioHora
            // 
            this.lblSalarioHora.AutoSize = true;
            this.lblSalarioHora.Location = new System.Drawing.Point(48, 123);
            this.lblSalarioHora.Name = "lblSalarioHora";
            this.lblSalarioHora.Size = new System.Drawing.Size(168, 25);
            this.lblSalarioHora.TabIndex = 22;
            this.lblSalarioHora.Text = "Salário por Hora";
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.Location = new System.Drawing.Point(222, 126);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(288, 31);
            this.txtSalarioHora.TabIndex = 23;
            this.txtSalarioHora.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDiasFalta
            // 
            this.txtDiasFalta.Location = new System.Drawing.Point(209, 237);
            this.txtDiasFalta.Name = "txtDiasFalta";
            this.txtDiasFalta.Size = new System.Drawing.Size(301, 31);
            this.txtDiasFalta.TabIndex = 24;
            // 
            // lblDiasFaltas
            // 
            this.lblDiasFaltas.AutoSize = true;
            this.lblDiasFaltas.Location = new System.Drawing.Point(48, 237);
            this.lblDiasFaltas.Name = "lblDiasFaltas";
            this.lblDiasFaltas.Size = new System.Drawing.Size(150, 25);
            this.lblDiasFaltas.TabIndex = 25;
            this.lblDiasFaltas.Text = "Dias de Faltas";
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PClasses.Properties.Resources.Pclasses1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 495);
            this.Controls.Add(this.lblDiasFaltas);
            this.Controls.Add(this.txtDiasFalta);
            this.Controls.Add(this.txtSalarioHora);
            this.Controls.Add(this.lblSalarioHora);
            this.Controls.Add(this.gbxHome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtNumHoras);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDAtaENtradaEmpresa);
            this.Controls.Add(this.lblNumHoras);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbnMatricula);
            this.Controls.Add(this.btnInstanciarHorista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.gbxHome.ResumeLayout(false);
            this.gbxHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHome;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumHoras;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblDAtaENtradaEmpresa;
        private System.Windows.Forms.Label lblNumHoras;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbnMatricula;
        private System.Windows.Forms.Button btnInstanciarHorista;
        private System.Windows.Forms.Label lblSalarioHora;
        private System.Windows.Forms.TextBox txtSalarioHora;
        private System.Windows.Forms.TextBox txtDiasFalta;
        private System.Windows.Forms.Label lblDiasFaltas;
    }
}