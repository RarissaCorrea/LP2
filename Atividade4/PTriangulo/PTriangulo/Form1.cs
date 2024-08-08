namespace PTriangulo
{
    public partial class PTriangulo : Form
    {
        public PTriangulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLado1.Clear();
            txtLado2.Clear();
            txtLado3.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(txtLado1.Text, out double a)
               || !double.TryParse(txtLado2.Text, out double b)
               || !double.TryParse(txtLado3.Text,out double c))
            {
                MessageBox.Show("Todos os valores precisam ser válidos");
            }
            else
            {
                if (a < (b + c) && a > Math.Abs(b - c)
                   && b < (a + c) && b > Math.Abs(a - c)
                   && c < (a + b) && c > Math.Abs(a - b))
                {
                    if(a == b && b == c)
                    {
                        MessageBox.Show("Triângulo Equilátero");
                    }
                    else if((a == b && b != c)
                            || (a ==c && c!= b)
                            || (b==c && c!= a))
                    {
                        MessageBox.Show("Triângulo Isósceles");
                    }
                    else
                    {
                        MessageBox.Show("Triângulo Escaleno");
                    }
                }
                else
                {
                    MessageBox.Show("Estes valores não correspondem a um triângulo");
                }
            }

        }
    }
}