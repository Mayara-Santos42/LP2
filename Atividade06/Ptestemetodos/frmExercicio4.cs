using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach (char c in txtMain.Text)
                if (char.IsNumber(c))
                    cont++;
            MessageBox.Show(cont.ToString());


        }

        private void BtnBranco_Click(object sender, EventArgs e)
        {
            int pos = -1;
            char[] vetor = txtMain.Text.ToCharArray();
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == ' ' && pos == -1)
                    pos = i;
            }
            MessageBox.Show(pos.ToString());
        }

        private void btnAlfa_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int i = 0;
            while (i < txtMain.Text.Length)
            {
                if (char.IsLetter(txtMain.Text.ElementAt(i)))
                    cont++;
                i++;
            }


            MessageBox.Show(cont.ToString());
        }
    }
}
