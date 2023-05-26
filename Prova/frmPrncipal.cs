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

namespace Prova
{
    public partial class frmPrncipal : Form
    {
        public frmPrncipal()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            double[,] Valores = new double[9, 4];
            double[] TotalMes = new double[9];
            string valor;
            double totalGeral = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    valor = Interaction.InputBox("Digite o valor da semana: " + (j + 1) + "\n" +
                        "Digite o valor do mês: " + (i + 1), "Entrada de Dados: ");
                    if (valor == "")
                    {
                        MessageBox.Show("Valor vazio!!");
                        j--;
                    }
                    else if (double.TryParse(valor, out Valores[i, j]))
                    {
                        double.TryParse(valor, out Valores[i, j]);

                    }
                    else
                    {
                        MessageBox.Show("Digite apenas números!!");
                        j--;
                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    TotalMes[i] = TotalMes[i] + Valores[i, j];
                }
                totalGeral = totalGeral + TotalMes[i];
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    lstbxVendas.Items.Add("Total do Mês: " + (i + 1) + " Semana: " + (j + 1) + ": R$" + Valores[i, j].ToString("N2"));
                }
                lstbxVendas.Items.Add(">>Total Mês: R$" + TotalMes[i].ToString("N2"));
                lstbxVendas.Items.Add("...............................");
            }
            lstbxVendas.Items.Add("Total Geral: R$" + totalGeral.ToString("N2"));

        }
    }
}
