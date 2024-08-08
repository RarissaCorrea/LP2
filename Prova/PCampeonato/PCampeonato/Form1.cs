using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PCampeonato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Julia Cassemiro e Rarissa Silva Correa

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int[,] Gols = new int[9, 3];
            string golsFeitos, golsReceb;
            int totalFeitos=0, totalRecebidos=0;

            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        golsFeitos = Interaction.InputBox("Digite gols feitos pelo time " + (i + 1).ToString(), "Entrada de dados");

                        if (!Int32.TryParse(golsFeitos, out Gols[i, j]))
                        {
                            MessageBox.Show("Insira quantidade de gols válida");
                            j--;
                        }
                        else if (Gols[i, j] < 0)
                        {
                            MessageBox.Show("Insira quantidade de gols válida");
                            j--;
                        }
                        else
                            totalFeitos += Gols[i, j];
                    }


                    if (j == 1)
                    {
                        golsReceb = Interaction.InputBox("Digite gols recebidos pelo time " + (i + 1).ToString(), "Entrada de dados");

                        if (!Int32.TryParse(golsReceb, out Gols[i, j]))
                        {
                            MessageBox.Show("Insira quantidade de gols válida");
                            j--;
                        }
                        else if (Gols[i, j] < 0)
                        {
                            MessageBox.Show("Insira quantidade de gols válida");
                            j--;
                        }
                        else
                            totalRecebidos += Gols[i, j];
                    }

                    if (j == 2)
                    {
                        Gols[i, j] = Gols[i, 0] - Gols[i, 1];
                    }
                }
                lbxResultado.Items.Add("Time:"+ (i + 1).ToString() + " Gols feitos:" + Gols[i,0].ToString() + " Gols recebidos:" + Gols[i,1].ToString() + " Saldo de gols:" + Gols[i, 2].ToString());
            }
            lbxResultado.Items.Add("-------------------------------------------------------------------------------------");
            lbxResultado.Items.Add("Total gols feitos:" + totalFeitos.ToString());
            lbxResultado.Items.Add("Total gols recebidos:" + totalRecebidos.ToString());
        }
    }
}
