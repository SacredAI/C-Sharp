using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_Machine
{
    public partial class Form1 : Form
    {

        double money = 0;
        double price;

        public Form1()
        {
            InitializeComponent();
        }

        private void rbt_llb_CheckedChanged(object sender, EventArgs e)
        {
            btn_dispense.Enabled = false;

            if (rbt_llb.Checked == true)
            {
                btn_2d.Enabled = false;
                price = 1.95;
            }
            else
            {
                btn_2d.Enabled = true;
            }
        }

        private void btn_5c_Click(object sender, EventArgs e)
        {
            money += 0.05;
            lbl_money.Text = "$" + money.ToString();
            price_check();
        }

        private void btn_10c_Click(object sender, EventArgs e)
        {
            money += 0.10;
            lbl_money.Text = "$" + money.ToString();
            price_check();
        }

        private void btn_20c_Click(object sender, EventArgs e)
        {
            money += 0.20;
            lbl_money.Text = "$" + money.ToString();
            price_check();
        }

        private void btn_50c_Click(object sender, EventArgs e)
        {
            money += 0.50;
            lbl_money.Text = "$" + money.ToString();
            price_check();
        }

        private void btn_1d_Click(object sender, EventArgs e)
        {
            money += 1.00;
            lbl_money.Text = "$" + money.ToString();
            price_check();
        }

        private void btn_2d_Click(object sender, EventArgs e)
        {
            money += 2.00;
            lbl_money.Text = "$" + money.ToString();
            price_check();
        }

        private void rbt_coke_CheckedChanged(object sender, EventArgs e)
        {
            if(rbt_coke.Enabled == true)
            {
                price = 2.45;
            }
        }

        public void price_check()
        {
            if(money == price)
            {
                btn_dispense.Enabled = true;
                btn_5c.Enabled = false;
            }else
            {
                btn_dispense.Enabled = false;
                btn_5c.Enabled = true;
            }
            if(money < price)
            {
                if (price - 0.05 <= money)
                {
                    btn_50c.Enabled = false;
                    btn_20c.Enabled = false;
                    btn_1d.Enabled = false;
                    btn_2d.Enabled = false;
                    btn_10c.Enabled = false;
                }else if (price - 0.10 <= money)
                {
                    btn_10c.Enabled = false;
                    btn_50c.Enabled = false;
                    btn_20c.Enabled = false;
                    btn_1d.Enabled = false;
                    btn_2d.Enabled = false;
                }else if (price - 0.20 <= money)
                {
                    btn_20c.Enabled = false;
                    btn_50c.Enabled = false;
                    btn_1d.Enabled = false;
                    btn_2d.Enabled = false;
                }else if(price - 0.50 <= money)
                {
                    btn_50c.Enabled = false;
                    btn_1d.Enabled = false;
                    btn_2d.Enabled = false;
                }else if (price - 1 <= money)
                {
                    btn_1d.Enabled = false;
                    btn_2d.Enabled = false;
                }
            }
        }

        private void btn_dispense_Click(object sender, EventArgs e)
        {
            if (money == price)
            {
                MessageBox.Show("Heres Your Drink!");
                money = 0;
                lbl_money.Text = money.ToString();
                btn_5c.Enabled = true;
                btn_10c.Enabled = true;
                btn_50c.Enabled = true;
                btn_20c.Enabled = true;
                btn_1d.Enabled = true;
                if (rbt_llb.Checked == true)
                {
                    btn_2d.Enabled = false;
                }else
                {
                    btn_2d.Enabled = true;
                }
            }
        }

        private void rbt_ginger_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_ginger.Enabled == true)
            {
                price = 4.25;
            }
        }
    }
}
