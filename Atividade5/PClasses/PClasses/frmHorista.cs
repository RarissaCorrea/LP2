using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInstanciarHorista_Click(object sender, EventArgs e)
        {
             //criar ou intanciar objeto da classe Horista

            Horista objHorista = new Horista();

            //set

            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumHoras.Text);
            if (rbtnSim.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';

            //get
            MessageBox.Show("Matrícula: " + objHorista.Matricula + "\n" + "Nome:" + objHorista.NomeEmpregado + "\n" + "Data Entrada: " +
                            objHorista.DataEntradaEmpresa.ToShortDateString() + "\n" + "Salário Bruto: " + objHorista.SalarioBruto().ToString("N2")
                            + "\n" + "Tempo Empresa (dias): " + objHorista.TempoTrabalho() + '\n' + objHorista.VerificaHome());
        }
    }
}
