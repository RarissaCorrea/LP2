﻿namespace PClasses
{
    partial class frmPrincipal
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
            this.btnMensalista = new System.Windows.Forms.Button();
            this.btnHorista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMensalista
            // 
            this.btnMensalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensalista.Location = new System.Drawing.Point(164, 366);
            this.btnMensalista.Name = "btnMensalista";
            this.btnMensalista.Size = new System.Drawing.Size(155, 96);
            this.btnMensalista.TabIndex = 0;
            this.btnMensalista.Text = "Mensalista";
            this.btnMensalista.UseVisualStyleBackColor = true;
            this.btnMensalista.Click += new System.EventHandler(this.btnMensalista_Click);
            // 
            // btnHorista
            // 
            this.btnHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorista.Location = new System.Drawing.Point(499, 366);
            this.btnHorista.Name = "btnHorista";
            this.btnHorista.Size = new System.Drawing.Size(155, 96);
            this.btnHorista.TabIndex = 1;
            this.btnHorista.Text = "Horista";
            this.btnHorista.UseVisualStyleBackColor = true;
            this.btnHorista.Click += new System.EventHandler(this.btnHorista_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PClasses.Properties.Resources.Pclasses;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 522);
            this.Controls.Add(this.btnHorista);
            this.Controls.Add(this.btnMensalista);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMensalista;
        private System.Windows.Forms.Button btnHorista;
    }
}

