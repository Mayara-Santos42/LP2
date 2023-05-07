using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLacos
{
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void BtnCalcSal_Click(object sender, EventArgs e)
        {
            double producao = double.Parse(txtProducao.Text), a = double.Parse(txtSalario.Text), salarioBruto,
                gratificacao = double.Parse(txtGratificacao.Text);

            int b = 0, c = 0, d = 0;
            if (producao >= 100)
                b = 1;
            if (producao >= 120)
                c = 1;
            if (producao >= 150)
                d = 1;

            salarioBruto = a + a * (0.05 * b + 0.1 * c + 0.1 * d);
            if (gratificacao == 0 || producao < 150)
                if (salarioBruto > 7000)
                    salarioBruto = 7000;
            MessageBox.Show("Salário Bruto: " + salarioBruto);
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
