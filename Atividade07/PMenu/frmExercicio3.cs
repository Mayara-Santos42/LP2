using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            int posicao=txtP2.Text.IndexOf(txtP1.Text);
            while (posicao >= 0)
            {
                txtP2.Text = txtP2.Text.Substring(0, posicao) +
                txtP2.Text.Substring(posicao + txtP1.Text.Length,
                txtP2.Text.Length - posicao - txtP1.Text.Length);


                posicao = txtP2.Text.IndexOf(txtP1.Text);
            }

        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            txtP2.Text = txtP2.Text.Replace(txtP1.Text,"");
        }

        private void BtnInverte_Click(object sender, EventArgs e)
        {
            char[] vetor = txtP1.Text.ToCharArray();
            Array.Reverse(vetor);
            string retorno = "";

            foreach (char c in vetor)
                retorno += c;

            txtP2.Text = retorno.ToString();
        }
    }
}
