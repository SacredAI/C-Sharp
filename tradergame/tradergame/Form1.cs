using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tradergame
{
    public partial class Form1 : Form
    {
        int hoursLeft;
        int stocks;
        int money;
        int tradePrice;
        int buy;
        int sell;


        public Form1()
        {
            InitializeComponent();
            generateRandomTradePrice();
            hoursLeft = int.Parse(lbl_hours.Text);
            stocks = int.Parse(lbl_stocks.Text);
            money = int.Parse(lbl_money.Text);
        }

        public void generateRandomTradePrice()
        {
            Random rnd = new Random();
            tradePrice = rnd.Next(1, 20) + 1;
            lbl_stockprice.Text = tradePrice.ToString();
        }
        
        public void update()
        { 
            lbl_hours.Text = hoursLeft.ToString();
            lbl_stocks.Text = stocks.ToString();
            lbl_money.Text = money.ToString();
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            try{
                buy = int.Parse(tbx_buyamount.Text);
            }catch (FormatException ex)
            {
                return;
            }
            int cost = buy * tradePrice;
            if(cost <= money)
            {
                money -= cost;
                stocks += buy;
                MessageBox.Show("Bought " + buy + " stocks, which cost you $" + cost);
                update();
            }
        }

        private void btn_sell_Click(object sender, EventArgs e)
        {
            try
            {
                sell = int.Parse(tbx_sellamount.Text);
            }
            catch (FormatException ex)
            {
                return;
            }
            if (sell <= stocks)
            {
                int profit = sell * tradePrice;
                money += profit;
                stocks -= sell;
                MessageBox.Show("Sold " + sell + " stocks, you have made $" + profit);
                update();
            }
        }

        private void btn_wait_Click(object sender, EventArgs e)
        {
            hoursLeft -= 1;
            if(hoursLeft < 1)
            {
                MessageBox.Show("GAME OVER. FINAL SCORE: $" + money);
                Application.Exit();
            }else
            {
                generateRandomTradePrice();
                update();
                MessageBox.Show("An hour has passed..");
            }
        }
    }
}
