using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rdoNerd.Checked)
            {
                MessageBox.Show("THE NERDS SHALL SURVIVE");
            }else if (rdoMemez.Checked)
            {
                MessageBox.Show("BEGONE THOT");
            }else
            {
                MessageBox.Show("YOU SHALL DIE!");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            lblTest.Text = "Hehe";
            btnTest.Enabled = false;
            btnTest.Visible = false;
        }

        private void lblTest_Hover(object sender, EventArgs e)
        {
            MessageBox.Show("Shoo Shoo");
        }
    }
}
