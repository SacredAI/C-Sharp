using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class RockPaperScissors : Form
    {

        int bet;
        int money;
        int plychoice;
        int comchoice;

        public RockPaperScissors()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Form_Main.staticVar.Show();
        }

        private void RockPaperSissors_Load(object sender, EventArgs e)
        {
            money = int.Parse(lbl_money.Text);   
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Main.staticVar.Show();
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            money = 100;
            lbl_money.Text = "100";
            plychoice = 0;
            comchoice = 0;
        }

        private void btn_rock_Click(object sender, EventArgs e)
        {
            try
            {
                bet = int.Parse(tbx_bet.Text);
                if (bet == 0)
                {
                    MessageBox.Show("Please Enter a valid Bet amount");
                    tbx_bet.Text = "0";
                    return;
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Please Enter a valid Bet amount");
                tbx_bet.Text = "0";
                return;
            } 
            plychoice = 1;
            pbx_ply.Image = Image.FromFile(@"assets/rps/140Rock.png");
            com();
            wincheck();
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            try
            {
                bet = int.Parse(tbx_bet.Text);
                if(bet == 0)
                {
                    MessageBox.Show("Please Enter a valid Bet amount");
                    tbx_bet.Text = "0";
                    return;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please Enter a valid Bet amount");
                tbx_bet.Text = "0";
                return;
            }
            plychoice = 2;
            pbx_ply.Image = Image.FromFile(@"assets/rps/140Paper.png");
            com();
            wincheck();
        }

        private void btn_sissiors_Click(object sender, EventArgs e)
        {
            try
            {
                bet = int.Parse(tbx_bet.Text);
                if (bet == 0)
                {
                    MessageBox.Show("Please Enter a valid Bet amount");
                    tbx_bet.Text = "0";
                    return;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please Enter a valid Bet amount");
                tbx_bet.Text = "0";
                return;
            }
            plychoice = 3;
            pbx_ply.Image = Image.FromFile(@"assets/rps/140Scissors.png");
            com();
            wincheck();
        }

        public void com()
        {
            Random rnd = new Random();
            comchoice = rnd.Next(1, 4);

            if (comchoice == 1)
            {
                pbx_com.Image = Image.FromFile(@"assets/rps/140Rock.png");
            }else if (comchoice == 2)
            {
                pbx_com.Image = Image.FromFile(@"assets/rps/140Paper.png");
            }else if (comchoice == 1)
            {
                pbx_com.Image = Image.FromFile(@"assets/rps/140Scissors.png");
            }
        }

        public void wincheck()
        {
            if (plychoice == comchoice)
            {
                MessageBox.Show("It's a Draw");
                tbx_bet.Text = "0";
            }
            else if (plychoice == 1 && comchoice == 3)
            {
                MessageBox.Show("You Won!");
                tbx_bet.Text = "0";
                money += bet;
                lbl_money.Text = money.ToString();
            }
            else if (plychoice == 2 && comchoice == 1)
            {
                MessageBox.Show("You Won!");
                tbx_bet.Text = "0";
                money += bet * 2;
                lbl_money.Text = money.ToString();
            }
            else if (plychoice == 3 && comchoice == 2)
            {
                MessageBox.Show("You Won!");
                tbx_bet.Text = "0";
                money += bet * 2;
                lbl_money.Text = money.ToString();
            }
            else if (plychoice == 3 && comchoice == 1)
            {
                MessageBox.Show("You Lost!");
                tbx_bet.Text = "0";
                money -= bet;
                lbl_money.Text = money.ToString();
            }
            else if (plychoice == 1 && comchoice == 2)
            {
                MessageBox.Show("You Lost!");
                tbx_bet.Text = "0";
                money -= bet;
                lbl_money.Text = money.ToString();
            }
            else if (plychoice == 2 && comchoice == 3)
            {
                MessageBox.Show("You Lost!");
                tbx_bet.Text = "0";
                money -= bet;
                lbl_money.Text = money.ToString();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.wikihow.com/Play-Rock,-Paper,-Scissors");
            }
            catch (Exception)
            {
            }
        }
    }
}
