using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anwser = add();

            MessageBox.Show(anwser.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int anwser = add();

            anwser = anwser * 5;

            MessageBox.Show(anwser.ToString());
        }

        public int add()
        {
            int num1;
            int num2;

            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);

            int anwser = num1 + num2;

            return anwser;
        }
    }
}
