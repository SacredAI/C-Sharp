using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        List<Panel> panels = new List<Panel>();
        int pan = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panels.Add(panel1);
            panels.Add(panel2);
            panels.Add(panel3);

            panels[pan].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pan < panels.Count - 1)
            {
                panels[++pan].BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pan > 0)
            {
                panels[--pan].BringToFront();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
