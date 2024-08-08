namespace Pimc
{
    public partial class PImc : Form
    {
        public PImc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            if (double.TryParse(txtAltura.Text, out double valor1) || txtAltura.Text == "")
            {
            }
            else
            {
                MessageBox.Show("Valor invalido");
                txtAltura.Focus();
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Imc, Peso, Altura;
            if (double.TryParse(txtAltura.Text, out  Altura) && double.TryParse(txtPeso.Text, out Peso))
            {
                Imc = Peso / (Altura * Altura);

                if(Imc < 18.5)
                    MessageBox.Show("Resultado: "+Math.Round(Imc,2)+ " Magreza");
                else if(Imc >= 18.5 && Imc < 25.0)
                    MessageBox.Show("Resultado: "+ Math.Round(Imc, 2) + " Normal");
                else if(Imc >= 25.0 && Imc < 30.0)
                    MessageBox.Show("Resultado: "+ Math.Round(Imc, 2) + " Sobrepeso");
                else if (Imc >= 30.0 && Imc < 40.0)
                    MessageBox.Show("Resultado: "+ Math.Round(Imc, 2) + " Obesidade");
                else
                    MessageBox.Show("Resultado: "+ Math.Round(Imc, 2) + " Obesidade Grave");
            }
        }

        private void txtPeso_Validated(object sender, EventArgs e)
        {
            if (double.TryParse(txtPeso.Text, out double valor1) || txtPeso.Text == "")
            {
            }
            else
            {
                MessageBox.Show("Valor invalido");
                txtPeso.Focus();
            }
        }
    }
}