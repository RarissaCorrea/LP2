using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtresultado.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtnumero2_Validated(object sender, EventArgs e)
        {
            if (double.TryParse(txtnumero2.Text, out double valor2) || txtnumero2.Text == "")
            {
               
            }
            else
            {
                MessageBox.Show("Valor invalido");
                txtnumero2.Focus();
            }
        }

        private void txtnumero1_Validated(object sender, EventArgs e)
        {
            if (double.TryParse(txtnumero1.Text, out double valor1) || txtnumero1.Text == "")
            {
            }
            else
            {
                MessageBox.Show("Valor invalido");
                txtnumero1.Focus();
            }
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtnumero1.Text, out double valor1) && double.TryParse(txtnumero2.Text, out double valor2))
            {
                txtresultado.Text = (valor1 + valor2).ToString();
            }
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtnumero1.Text, out double valor1) && double.TryParse(txtnumero2.Text, out double valor2))
            {
                txtresultado.Text = (valor1 - valor2).ToString();
            }
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtnumero1.Text, out double valor1) && double.TryParse(txtnumero2.Text, out double valor2))
            {
                txtresultado.Text = (valor1 * valor2).ToString();
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtnumero1.Text, out double valor1) && double.TryParse(txtnumero2.Text, out double valor2))
            {
                if (txtnumero2.Text == "0")
                {
                    MessageBox.Show("impossivel divisão por zero");
                    txtnumero2.Focus();
                }
                else
                {
                    txtresultado.Text = (valor1 / valor2).ToString();
                }
            }  
        }

        private void txtnumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
