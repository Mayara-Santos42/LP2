using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjSalário
{
    public partial class ProjetoSalario : Form
    {
        public ProjetoSalario()
        {
            InitializeComponent();
        }


        string nome;
        double salBruto;
        int numFilhos;
        char sexo = 'm';
        bool eh_casado;

        double aliqInss;
        double aliqIrff;
        double salFam;
        double salLiq;
        double descInss;
        double descIrrf;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtNome_Validated(object sender, EventArgs e)
        {
            if(txtNome.Text != string.Empty)
                nome = txtNome.Text;
            else
            {
                MessageBox.Show("Digite um nome");
                txtNome.Focus();
            }
                
        }

        private void MskbxSalBruto_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxSalBruto.Text, out salBruto))
            {
                MessageBox.Show("Salário Inválido");
                mskbxSalBruto.Focus();
            }
                
                
        }

        private void NmrcFilhos_Validated(object sender, EventArgs e)
        {
            if (!int.TryParse(nmrcFilhos.Text, out numFilhos))
                MessageBox.Show("Número de Filhos Inválido");
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Caracter inválido");
                e.KeyChar = '\0';
            }
        }

        private void RdbtnM_Click(object sender, EventArgs e)
        {
            rbtnF.Checked = false;
            sexo = 'm';
        }

        private void RbtnF_Click(object sender, EventArgs e)
        {
            rbtnF.Checked = true;
            sexo = 'f';
        }

        private void CkbxCasado_Click(object sender, EventArgs e)
        {
            if (ckbxCasado.Checked)
                eh_casado = true;
            else
                eh_casado = false;
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(mskbxSalBruto.Text, out salBruto))
            {
                MessageBox.Show("Insira um valor para salário");
                return;
            }
            if (salBruto <= 0)
            {
                MessageBox.Show("Insira um sal válido");
                return;
            }
                

            if (salBruto <= 800.47)
            {
                aliqInss = 0.0765;
                txtAliqInss.Text = "7,65%";
            }
            else if (salBruto <= 1050)
            {
                aliqInss = 0.0865;
                txtAliqInss.Text = "8,65%";
            }
            else if (salBruto <= 1400.77)
            {
                txtAliqInss.Text = "9%";
                aliqInss = 0.09;
            }
            else if (salBruto <= 2801.56)
            {
                txtAliqInss.Text = "11%";
                aliqInss = 0.11;
            }
            else
                aliqInss = -1;
                txtAliqInss.Text = "FIXA";

            if (salBruto <= 1257.12)
            {
                txtAliqIrrf.Text = "0%";
                aliqIrff = 0;
            }
            else if(salBruto <= 2512.08)
            {
                aliqIrff = 0.15;
                txtAliqIrrf.Text = "15%";
            }
            else
            {
                aliqIrff = 0.275;
                txtAliqIrrf.Text = "27.5%";

            }

            if (salBruto <= 435.52)
                salFam = 22.33 * numFilhos;
            else if (salBruto <= 654.61)
                salFam = 15.74 * numFilhos;
            else
                salFam = 0;

            if(aliqInss > 0)
            {
                descInss = salBruto * aliqInss;
            }
            else
            {
                descInss = 308.17;
            }

            descIrrf = salBruto * aliqIrff;

            salLiq = salBruto - descIrrf - descInss + salFam;

            txtDescInss.Text = descInss.ToString("C");
            txtDescIrrf.Text = descIrrf.ToString("C");
            txtSalLiq.Text = salLiq.ToString("C");
            txtSalFal.Text = salFam.ToString("C");

            lblDados.Text = "Os descontos do salário de " + nome + " que é ";
            if (eh_casado)
            {
                lblDados.Text += "casado(a)";
            }
            else
                lblDados.Text += "solteiro(a)";
            lblDados.Text += " e que tem " + numFilhos.ToString() + " Filho(s)";

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
