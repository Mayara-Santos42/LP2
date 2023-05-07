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
    public partial class frmExercicio2 : Form
    {
        
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void BtnComparar_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0)
            {
                MessageBox.Show("São iguais");
            }
            else
            {
                MessageBox.Show("São diferentes");
            }
        }

        private void BtnMeio_Click(object sender, EventArgs e)
        {
            int Metade = txtPalavra2.TextLength / 2;
            txtPalavra2.Text = txtPalavra2.Text.Substring(0, Metade) + txtPalavra1.Text + txtPalavra2.Text.Substring(Metade, txtPalavra2.TextLength - Metade);
        }

        private void BtnAsterisco_Click(object sender, EventArgs e)
        {
            int Metade = txtPalavra1.TextLength / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(Metade, "**");
        }
    }
}
