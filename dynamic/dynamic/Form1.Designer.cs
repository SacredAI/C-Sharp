namespace dynamic
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
            this.btn_roll = new System.Windows.Forms.Button();
            this.pic_dice = new System.Windows.Forms.PictureBox();
            this.tbx_bet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_money = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdb_lower = new System.Windows.Forms.RadioButton();
            this.rdb_higher = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dice)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_roll
            // 
            this.btn_roll.Location = new System.Drawing.Point(166, 42);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(99, 61);
            this.btn_roll.TabIndex = 0;
            this.btn_roll.Text = "Roll";
            this.btn_roll.UseVisualStyleBackColor = true;
            this.btn_roll.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic_dice
            // 
            this.pic_dice.Location = new System.Drawing.Point(12, 12);
            this.pic_dice.Name = "pic_dice";
            this.pic_dice.Size = new System.Drawing.Size(135, 135);
            this.pic_dice.TabIndex = 1;
            this.pic_dice.TabStop = false;
            this.pic_dice.Click += new System.EventHandler(this.pic_dice_Click);
            // 
            // tbx_bet
            // 
            this.tbx_bet.Location = new System.Drawing.Point(127, 221);
            this.tbx_bet.Name = "tbx_bet";
            this.tbx_bet.Size = new System.Drawing.Size(100, 22);
            this.tbx_bet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Money: $";
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_money.Location = new System.Drawing.Point(109, 181);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(40, 24);
            this.lbl_money.TabIndex = 4;
            this.lbl_money.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bet Amount:";
            // 
            // rdb_lower
            // 
            this.rdb_lower.AutoSize = true;
            this.rdb_lower.Location = new System.Drawing.Point(294, 42);
            this.rdb_lower.Name = "rdb_lower";
            this.rdb_lower.Size = new System.Drawing.Size(50, 21);
            this.rdb_lower.TabIndex = 6;
            this.rdb_lower.TabStop = true;
            this.rdb_lower.Text = "1-3";
            this.rdb_lower.UseVisualStyleBackColor = true;
            // 
            // rdb_higher
            // 
            this.rdb_higher.AutoSize = true;
            this.rdb_higher.Location = new System.Drawing.Point(294, 82);
            this.rdb_higher.Name = "rdb_higher";
            this.rdb_higher.Size = new System.Drawing.Size(50, 21);
            this.rdb_higher.TabIndex = 7;
            this.rdb_higher.TabStop = true;
            this.rdb_higher.Text = "4-6";
            this.rdb_higher.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 416);
            this.Controls.Add(this.rdb_higher);
            this.Controls.Add(this.rdb_lower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_bet);
            this.Controls.Add(this.pic_dice);
            this.Controls.Add(this.btn_roll);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_dice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.PictureBox pic_dice;
        private System.Windows.Forms.TextBox tbx_bet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdb_lower;
        private System.Windows.Forms.RadioButton rdb_higher;
    }
}

