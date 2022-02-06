using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamic
{
    public partial class Form1 : Form
    {
        int bet;
        int money;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1,7);
            try
            {
                money = int.Parse(lbl_money.Text);
                bet = int.Parse(tbx_bet.Text);
                if(money == 0)
                {
                    MessageBox.Show("Please Place A Bet!");
                    return;
                }
            }catch(FormatException ex)
            {
                MessageBox.Show("Please Take a guess!");
                return;
            }

            pic_dice.Image = Image.FromFile(@"dice/dice" + dice + ".bmp");

            if(rdb_higher.Checked == true)
            {
                if(dice > 3)
                {
                    MessageBox.Show("You Won!");
                    money += bet;
                    tbx_bet.Text = "0";
                    lbl_money.Text = money.ToString();
                }else
                {
                    MessageBox.Show("You Lost!");
                    money -= bet;
                    tbx_bet.Text = "0";
                    lbl_money.Text = money.ToString();
                }
            }else if(rdb_lower.Checked == true)
            {
                if(dice < 4)
                {
                    MessageBox.Show("You Won!");
                    money += bet;
                    tbx_bet.Text = "0";
                    lbl_money.Text = money.ToString();
                }
                else
                {
                    MessageBox.Show("You Lost!");
                    money -= bet;
                    tbx_bet.Text = "0";
                    lbl_money.Text = money.ToString();
                }

                if(money == 0)
                {
                    MessageBox.Show("Looks Like Your Out of Money! See you next time!");
                    Application.Exit();
                }
            }
        }

        private void pic_dice_Click(object sender, EventArgs e)
        {

        }
    }
}
