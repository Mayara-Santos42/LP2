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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtH.Text);
            double acc = 0;
            if(num > 0)
            {
                for (var i = 1; i <= num; i++)
                {
                    acc += 1.0 / i;
                }
                MessageBox.Show("H: " + acc.ToString());
            }
            else
                MessageBox.Show("N precisa ser maior que 0");

        }
    }
}
