using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form_Main : Form
    {
        public static Form staticVar;

        public Form_Main()
        {
            InitializeComponent();
            staticVar = this;
        }

        private void btn_rps_Click(object sender, EventArgs e)
        {
            Form rps = new RockPaperScissors();
            rps.Show();
            this.Hide();
        }

        private void btn_rps_Hover(object sender, EventArgs e)
        {
            btn_rps.BackColor = Color.Gray;
            btn_rps.Width = 120;
            btn_rps.Height = 110;
            btn_rps.BringToFront();
        }

        private void btn_rps_Mouseleave(object sender, EventArgs e)
        {
            btn_rps.BackColor = Color.Black;
            btn_rps.Width = 82;
            btn_rps.Height = 65;
        }

        private void btn_blackjack_Click(object sender, EventArgs e)
        {
            Form bj = new BlackJack();
            bj.Show();
            this.Hide();
        }

        private void btn_blackjack_Hover(object sender, EventArgs e)
        {
            btn_blackjack.BackColor = Color.Gray;
            btn_blackjack.Width = 120;
            btn_blackjack.Height = 110;
            btn_blackjack.BringToFront();
        }

        private void btn_blackjack_Mouseleave(object sender, EventArgs e)
        {
            btn_blackjack.BackColor = Color.Black;
            btn_blackjack.Width = 82;
            btn_blackjack.Height = 65;
        }

        private void btn_minesweeper_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("D:/Documents/adonnellan/My Documents/Coding Projects/Assignment/MineSweeper/bin/Debug/MineSweeper.exe");
            int id = process.Id;
            Process tempProc = Process.GetProcessById(id);
            this.Visible = false;
            tempProc.WaitForExit();
            this.Visible = true;
        }

        private void btn_minesweeper_Hover(object sender, EventArgs e)
        {
            btn_minesweeper.BackColor = Color.Gray;
            btn_minesweeper.Width = 120;
            btn_minesweeper.Height = 110;
            btn_minesweeper.BringToFront();
        }

        private void btn_minesweeper_Mouseleave(object sender, EventArgs e)
        {
            btn_minesweeper.BackColor = Color.Black;
            btn_minesweeper.Width = 82;
            btn_minesweeper.Height = 65;
        }
    }
}
