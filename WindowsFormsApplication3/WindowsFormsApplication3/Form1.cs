using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txb_input_1.Text);
            int num2 = int.Parse(txb_input_2.Text);
            int num3 = num2 + num1;

            MessageBox.Show("The Addition of " + num1 + " and " + num2 + " resulted in " + num3);

            if (num1 > num2)
            {
                MessageBox.Show(num1 + " Is greater than " + num2);
            } else if (num1 < num2)
            {
                MessageBox.Show(num1 + " Is Less than " + num2);
            }else if(num1 == num2)
            {
                MessageBox.Show("The Numbers are the Same");
            }
        }
    }
}
