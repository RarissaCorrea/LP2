namespace Pvolume
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
            this.btnsair = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblraio = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblvolume = new System.Windows.Forms.Label();
            this.txtraio = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtvolume = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsair.Image = global::Pvolume.Properties.Resources.fundo_abstrato_com_desenho_de_poliester_em_tons_pasteis_1048_14869;
            this.btnsair.Location = new System.Drawing.Point(52, 344);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(149, 96);
            this.btnsair.TabIndex = 0;
            this.btnsair.Text = "Calcular";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Image = global::Pvolume.Properties.Resources.fundo_abstrato_com_desenho_de_poliester_em_tons_pasteis_1048_148691;
            this.btnlimpar.Location = new System.Drawing.Point(325, 344);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(149, 96);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Sair";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.Control;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalcular.Image = global::Pvolume.Properties.Resources.fundo_abstrato_com_desenho_de_poliester_em_tons_pasteis_1048_14869;
            this.btncalcular.Location = new System.Drawing.Point(570, 344);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(149, 96);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Limpar";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblraio
            // 
            this.lblraio.AutoSize = true;
            this.lblraio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblraio.Location = new System.Drawing.Point(12, 71);
            this.lblraio.Name = "lblraio";
            this.lblraio.Size = new System.Drawing.Size(56, 25);
            this.lblraio.TabIndex = 3;
            this.lblraio.Text = "Raio";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(12, 152);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(68, 25);
            this.lblaltura.TabIndex = 4;
            this.lblaltura.Text = "Altura";
            // 
            // lblvolume
            // 
            this.lblvolume.AutoSize = true;
            this.lblvolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvolume.Location = new System.Drawing.Point(12, 238);
            this.lblvolume.Name = "lblvolume";
            this.lblvolume.Size = new System.Drawing.Size(84, 25);
            this.lblvolume.TabIndex = 5;
            this.lblvolume.Text = "Volume";
            // 
            // txtraio
            // 
            this.txtraio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtraio.Location = new System.Drawing.Point(116, 65);
            this.txtraio.Name = "txtraio";
            this.txtraio.Size = new System.Drawing.Size(398, 31);
            this.txtraio.TabIndex = 6;
            this.txtraio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtraio_KeyPress);
            // 
            // txtaltura
            // 
            this.txtaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltura.Location = new System.Drawing.Point(116, 146);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(398, 31);
            this.txtaltura.TabIndex = 7;
            this.txtaltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtraio_KeyPress);
            // 
            // txtvolume
            // 
            this.txtvolume.Enabled = false;
            this.txtvolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvolume.Location = new System.Drawing.Point(118, 235);
            this.txtvolume.Name = "txtvolume";
            this.txtvolume.Size = new System.Drawing.Size(398, 31);
            this.txtvolume.TabIndex = 8;
            this.txtvolume.TextChanged += new System.EventHandler(this.txtvolume_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pvolume.Properties.Resources.pngtree_cute_hand_drawn_style_math_education_plaid_background_image_337365;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 523);
            this.Controls.Add(this.txtvolume);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtraio);
            this.Controls.Add(this.lblvolume);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblraio);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsair);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblraio;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblvolume;
        private System.Windows.Forms.TextBox txtraio;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtvolume;
    }
}

