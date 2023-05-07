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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void BtnEspaco_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach(char x in rtxtFrase.Text)
            {
                if (char.IsWhiteSpace(x))
                    cont++;
            }
            MessageBox.Show("Numero de espacos em branco: " + cont.ToString());
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLetraR_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach (char x in rtxtFrase.Text)
            {
                if (char.ToUpper(x) == 'R')
                    cont++;
            }

            MessageBox.Show("Numero de Rs: " + cont.ToString());
        }

        private void BtnLetraRepetida_Click(object sender, EventArgs e)
        {
            
            int numPares = 0;
            for(var i = 0; i<rtxtFrase.Text.Length-1; i++)
            {
                if (rtxtFrase.Text[i] == rtxtFrase.Text[i+1])
                    numPares++;
                

            }
            MessageBox.Show("Número de pares é: " + numPares);
        }
    }
}
