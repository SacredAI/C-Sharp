namespace tradergame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.btn_wait = new System.Windows.Forms.Button();
            this.lbl_stocksowned = new System.Windows.Forms.Label();
            this.lbl_monyleft = new System.Windows.Forms.Label();
            this.lbl_cstockprice = new System.Windows.Forms.Label();
            this.lbl_money = new System.Windows.Forms.Label();
            this.lbl_stocks = new System.Windows.Forms.Label();
            this.lbl_stockprice = new System.Windows.Forms.Label();
            this.lbl_remaing = new System.Windows.Forms.Label();
            this.lbl_hours = new System.Windows.Forms.Label();
            this.tbx_buyamount = new System.Windows.Forms.TextBox();
            this.tbx_sellamount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(55, 258);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(44, 31);
            this.btn_buy.TabIndex = 0;
            this.btn_buy.Text = "buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.Location = new System.Drawing.Point(214, 258);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(40, 31);
            this.btn_sell.TabIndex = 1;
            this.btn_sell.Text = "sell";
            this.btn_sell.UseVisualStyleBackColor = true;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // btn_wait
            // 
            this.btn_wait.Location = new System.Drawing.Point(202, 348);
            this.btn_wait.Name = "btn_wait";
            this.btn_wait.Size = new System.Drawing.Size(106, 25);
            this.btn_wait.TabIndex = 2;
            this.btn_wait.Text = "Wait 1 hour";
            this.btn_wait.UseVisualStyleBackColor = true;
            this.btn_wait.Click += new System.EventHandler(this.btn_wait_Click);
            // 
            // lbl_stocksowned
            // 
            this.lbl_stocksowned.AutoSize = true;
            this.lbl_stocksowned.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stocksowned.Location = new System.Drawing.Point(6, 94);
            this.lbl_stocksowned.Name = "lbl_stocksowned";
            this.lbl_stocksowned.Size = new System.Drawing.Size(235, 24);
            this.lbl_stocksowned.TabIndex = 3;
            this.lbl_stocksowned.Text = "Number Of Owned Stocks:";
            // 
            // lbl_monyleft
            // 
            this.lbl_monyleft.AutoSize = true;
            this.lbl_monyleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monyleft.Location = new System.Drawing.Point(119, 152);
            this.lbl_monyleft.Name = "lbl_monyleft";
            this.lbl_monyleft.Size = new System.Drawing.Size(122, 24);
            this.lbl_monyleft.TabIndex = 6;
            this.lbl_monyleft.Text = "Money Left: $";
            // 
            // lbl_cstockprice
            // 
            this.lbl_cstockprice.AutoSize = true;
            this.lbl_cstockprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cstockprice.Location = new System.Drawing.Point(65, 38);
            this.lbl_cstockprice.Name = "lbl_cstockprice";
            this.lbl_cstockprice.Size = new System.Drawing.Size(176, 24);
            this.lbl_cstockprice.TabIndex = 7;
            this.lbl_cstockprice.Text = "Current Stock Price:";
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_money.Location = new System.Drawing.Point(240, 152);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(30, 24);
            this.lbl_money.TabIndex = 8;
            this.lbl_money.Text = "10";
            // 
            // lbl_stocks
            // 
            this.lbl_stocks.AutoSize = true;
            this.lbl_stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stocks.Location = new System.Drawing.Point(247, 94);
            this.lbl_stocks.Name = "lbl_stocks";
            this.lbl_stocks.Size = new System.Drawing.Size(20, 24);
            this.lbl_stocks.TabIndex = 9;
            this.lbl_stocks.Text = "0";
            // 
            // lbl_stockprice
            // 
            this.lbl_stockprice.AutoSize = true;
            this.lbl_stockprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stockprice.Location = new System.Drawing.Point(247, 38);
            this.lbl_stockprice.Name = "lbl_stockprice";
            this.lbl_stockprice.Size = new System.Drawing.Size(0, 24);
            this.lbl_stockprice.TabIndex = 10;
            // 
            // lbl_remaing
            // 
            this.lbl_remaing.AutoSize = true;
            this.lbl_remaing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remaing.Location = new System.Drawing.Point(-3, 346);
            this.lbl_remaing.Name = "lbl_remaing";
            this.lbl_remaing.Size = new System.Drawing.Size(167, 24);
            this.lbl_remaing.TabIndex = 11;
            this.lbl_remaing.Text = "Hours Remaining: ";
            // 
            // lbl_hours
            // 
            this.lbl_hours.AutoSize = true;
            this.lbl_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hours.Location = new System.Drawing.Point(166, 346);
            this.lbl_hours.Name = "lbl_hours";
            this.lbl_hours.Size = new System.Drawing.Size(30, 24);
            this.lbl_hours.TabIndex = 12;
            this.lbl_hours.Text = "12";
            // 
            // tbx_buyamount
            // 
            this.tbx_buyamount.Location = new System.Drawing.Point(28, 230);
            this.tbx_buyamount.Name = "tbx_buyamount";
            this.tbx_buyamount.Size = new System.Drawing.Size(100, 22);
            this.tbx_buyamount.TabIndex = 13;
            // 
            // tbx_sellamount
            // 
            this.tbx_sellamount.Location = new System.Drawing.Point(183, 230);
            this.tbx_sellamount.Name = "tbx_sellamount";
            this.tbx_sellamount.Size = new System.Drawing.Size(100, 22);
            this.tbx_sellamount.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 382);
            this.Controls.Add(this.tbx_sellamount);
            this.Controls.Add(this.tbx_buyamount);
            this.Controls.Add(this.lbl_hours);
            this.Controls.Add(this.lbl_remaing);
            this.Controls.Add(this.lbl_stockprice);
            this.Controls.Add(this.lbl_stocks);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.lbl_cstockprice);
            this.Controls.Add(this.lbl_monyleft);
            this.Controls.Add(this.lbl_stocksowned);
            this.Controls.Add(this.btn_wait);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.btn_buy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Button btn_sell;
        private System.Windows.Forms.Button btn_wait;
        private System.Windows.Forms.Label lbl_stocksowned;
        private System.Windows.Forms.Label lbl_monyleft;
        private System.Windows.Forms.Label lbl_cstockprice;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.Label lbl_stocks;
        private System.Windows.Forms.Label lbl_stockprice;
        private System.Windows.Forms.Label lbl_remaing;
        private System.Windows.Forms.Label lbl_hours;
        private System.Windows.Forms.TextBox tbx_buyamount;
        private System.Windows.Forms.TextBox tbx_sellamount;
    }
}

