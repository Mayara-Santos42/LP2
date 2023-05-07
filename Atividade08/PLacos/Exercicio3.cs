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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string textLimpo = "";
            bool eh_palindromo = true;
            foreach(char c in txtFrase.Text)
            {
                if (c != ' ')
                    textLimpo += c;
            }

            for(var i = 0; i < textLimpo.Length/2; i++)
            {
                if (textLimpo[i] != textLimpo[textLimpo.Length - i-1])
                    eh_palindromo = false;

            }

            if(eh_palindromo)
                MessageBox.Show("É palindromo");
            else
                MessageBox.Show("Não é palindromo");
        }
    }
}
