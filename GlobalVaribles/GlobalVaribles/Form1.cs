using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalVaribles
{
    public partial class Form1 : Form
    {

        public int num = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_minus10_Click(object sender, EventArgs e)
        {
            num -= 10;
            lbl_number.Text = num.ToString();
        }

        private void btn_plus5_Click(object sender, EventArgs e)
        {
            num += 5;
            lbl_number.Text = num.ToString();
        }
    }
}
