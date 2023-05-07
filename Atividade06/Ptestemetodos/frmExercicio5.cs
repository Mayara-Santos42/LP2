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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void txtBoxNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSortear_Click(object sender, EventArgs e)
        {

            int num1, num2;
            if (!int.TryParse(txtNum1.Text, out num1) || !int.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Entre valores válidos!");
                return;
            }


            Random rand = new Random();
            int randomNum = rand.Next(num1, num2 + 1);


            MessageBox.Show(randomNum.ToString());

        }
    }
}
