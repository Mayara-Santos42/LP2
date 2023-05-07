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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(Application.OpenForms.OfType<Exercicio1>().Count() > 0))
            {
                Exercicio1 ex1 = new Exercicio1();
                ex1.MdiParent = this;
                ex1.WindowState = FormWindowState.Maximized;
                ex1.Show();
            }
            else
                Application.OpenForms["Exercicio1"].BringToFront();

        }

        private void Exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Application.OpenForms.OfType<Exercicio2>().Count() > 0))
            {
                Exercicio2 ex1 = new Exercicio2();
                ex1.MdiParent = this;
                ex1.WindowState = FormWindowState.Maximized;
                ex1.Show();
            }
            else
                Application.OpenForms["Exercicio2"].BringToFront();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Application.OpenForms.OfType<Exercicio3>().Count() > 0))
            {
                Exercicio3 ex1 = new Exercicio3();
                ex1.MdiParent = this;
                ex1.WindowState = FormWindowState.Maximized;
                ex1.Show();
            }
            else
                Application.OpenForms["Exercicio3"].BringToFront();
        }

        private void Exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Application.OpenForms.OfType<Exercicio4>().Count() > 0))
            {
                Exercicio4 ex1 = new Exercicio4();
                ex1.MdiParent = this;
                ex1.WindowState = FormWindowState.Maximized;
                ex1.Show();
            }
            else
                Application.OpenForms["Exercicio4"].BringToFront();

        }
    }
}
