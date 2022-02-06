using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form2 : Form
    {

        public int width;
        public int length;
        public int bombs;
        public static Form st;

        public Form2()
        {
            InitializeComponent();
            st = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int diff = 1;

            Program.form.startGame(diff, 0, 0, 0);
            this.Close();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int diff = 2;

            Program.form.startGame(diff, 0, 0, 0);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int diff = 3;

            Program.form.startGame(diff, 0, 0, 0);
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int diff = 4;

            try
            {
                width = int.Parse(tbx_Width.Text);
                length = int.Parse(tbx_length.Text);
                bombs = int.Parse(tbx_bombs.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Please Enter Vaild Numbers");
                return;
            }

            Program.form.startGame(diff, width, length, bombs);

            this.Close();
        }
    }
}
