using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtnum1.Text);
                int num2 = int.Parse(txtnum2.Text);
                if (num1 > num2)
                {
                    MessageBox.Show("Number 1v is Bigger");
                }
                else if (num2 > num1)
                {
                    MessageBox.Show("Number 2 is Bugger");
                }
                else if (num1 == num2)
                {
                    MessageBox.Show("The Number Are the Same");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter 2 Numbers");
            }
        }
    }
}
