using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio, altura;

            if(Double.TryParse(txtaltura.Text, out altura) &&
                Double.TryParse(txtraio.Text, out raio))
            {
                if((altura <= 0) || (raio <= 0))
                {
                    MessageBox.Show("Taltura e raio devem ser maior que zero");
                    txtraio.Focus();
                }
                else
                {
                    double volume;

                    volume = Math.PI * Math.Pow(raio, 2) * altura;
                    txtvolume.Text = volume.ToString("N2");
                }
            }
            else
            {
                MessageBox.Show("Valores inválidos");
                txtraio.Focus();
            }
        }

        private void txtvolume_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtraio.Text = "";
            txtvolume.Text = string.Empty;

            txtraio.Focus();
        }

        private void txtraio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
