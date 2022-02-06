using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enabled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click1_Click(object sender, EventArgs e)
        {
            if(cbx_enable.Checked == true)
            {
                MessageBox.Show("Enabled!");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = false;
            radioButton2.Checked = false;
            radioButton1.Checked = false;
        }

        private void btn_click2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                radioButton3.Checked = false;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
        }
    }
}
