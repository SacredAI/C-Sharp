namespace Vending_Machine
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
            this.rbt_llb = new System.Windows.Forms.RadioButton();
            this.rbt_coke = new System.Windows.Forms.RadioButton();
            this.rbt_ginger = new System.Windows.Forms.RadioButton();
            this.btn_5c = new System.Windows.Forms.Button();
            this.btn_10c = new System.Windows.Forms.Button();
            this.btn_20c = new System.Windows.Forms.Button();
            this.btn_50c = new System.Windows.Forms.Button();
            this.btn_1d = new System.Windows.Forms.Button();
            this.btn_2d = new System.Windows.Forms.Button();
            this.btn_dispense = new System.Windows.Forms.Button();
            this.lbl_money = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbt_llb
            // 
            this.rbt_llb.AutoSize = true;
            this.rbt_llb.Location = new System.Drawing.Point(161, 150);
            this.rbt_llb.Name = "rbt_llb";
            this.rbt_llb.Size = new System.Drawing.Size(199, 21);
            this.rbt_llb.TabIndex = 0;
            this.rbt_llb.TabStop = true;
            this.rbt_llb.Text = "Lemon Lime Bitters - $1.95";
            this.rbt_llb.UseVisualStyleBackColor = true;
            this.rbt_llb.CheckedChanged += new System.EventHandler(this.rbt_llb_CheckedChanged);
            // 
            // rbt_coke
            // 
            this.rbt_coke.AutoSize = true;
            this.rbt_coke.Location = new System.Drawing.Point(161, 177);
            this.rbt_coke.Name = "rbt_coke";
            this.rbt_coke.Size = new System.Drawing.Size(110, 21);
            this.rbt_coke.TabIndex = 1;
            this.rbt_coke.TabStop = true;
            this.rbt_coke.Text = "Coke - $2.45";
            this.rbt_coke.UseVisualStyleBackColor = true;
            this.rbt_coke.CheckedChanged += new System.EventHandler(this.rbt_coke_CheckedChanged);
            // 
            // rbt_ginger
            // 
            this.rbt_ginger.AutoSize = true;
            this.rbt_ginger.Location = new System.Drawing.Point(161, 204);
            this.rbt_ginger.Name = "rbt_ginger";
            this.rbt_ginger.Size = new System.Drawing.Size(154, 21);
            this.rbt_ginger.TabIndex = 2;
            this.rbt_ginger.TabStop = true;
            this.rbt_ginger.Text = "Ginger beer - $4.25";
            this.rbt_ginger.UseVisualStyleBackColor = true;
            this.rbt_ginger.CheckedChanged += new System.EventHandler(this.rbt_ginger_CheckedChanged);
            // 
            // btn_5c
            // 
            this.btn_5c.Location = new System.Drawing.Point(24, 329);
            this.btn_5c.Name = "btn_5c";
            this.btn_5c.Size = new System.Drawing.Size(75, 23);
            this.btn_5c.TabIndex = 3;
            this.btn_5c.Text = "5c";
            this.btn_5c.UseVisualStyleBackColor = true;
            this.btn_5c.Click += new System.EventHandler(this.btn_5c_Click);
            // 
            // btn_10c
            // 
            this.btn_10c.Location = new System.Drawing.Point(115, 329);
            this.btn_10c.Name = "btn_10c";
            this.btn_10c.Size = new System.Drawing.Size(75, 23);
            this.btn_10c.TabIndex = 4;
            this.btn_10c.Text = "10c";
            this.btn_10c.UseVisualStyleBackColor = true;
            this.btn_10c.Click += new System.EventHandler(this.btn_10c_Click);
            // 
            // btn_20c
            // 
            this.btn_20c.Location = new System.Drawing.Point(218, 329);
            this.btn_20c.Name = "btn_20c";
            this.btn_20c.Size = new System.Drawing.Size(75, 23);
            this.btn_20c.TabIndex = 5;
            this.btn_20c.Text = "20c";
            this.btn_20c.UseVisualStyleBackColor = true;
            this.btn_20c.Click += new System.EventHandler(this.btn_20c_Click);
            // 
            // btn_50c
            // 
            this.btn_50c.Location = new System.Drawing.Point(318, 329);
            this.btn_50c.Name = "btn_50c";
            this.btn_50c.Size = new System.Drawing.Size(75, 23);
            this.btn_50c.TabIndex = 6;
            this.btn_50c.Text = "50c";
            this.btn_50c.UseVisualStyleBackColor = true;
            this.btn_50c.Click += new System.EventHandler(this.btn_50c_Click);
            // 
            // btn_1d
            // 
            this.btn_1d.Location = new System.Drawing.Point(79, 388);
            this.btn_1d.Name = "btn_1d";
            this.btn_1d.Size = new System.Drawing.Size(75, 23);
            this.btn_1d.TabIndex = 8;
            this.btn_1d.Text = "$1";
            this.btn_1d.UseVisualStyleBackColor = true;
            this.btn_1d.Click += new System.EventHandler(this.btn_1d_Click);
            // 
            // btn_2d
            // 
            this.btn_2d.Location = new System.Drawing.Point(286, 388);
            this.btn_2d.Name = "btn_2d";
            this.btn_2d.Size = new System.Drawing.Size(75, 23);
            this.btn_2d.TabIndex = 9;
            this.btn_2d.Text = "$2";
            this.btn_2d.UseVisualStyleBackColor = true;
            this.btn_2d.Click += new System.EventHandler(this.btn_2d_Click);
            // 
            // btn_dispense
            // 
            this.btn_dispense.Location = new System.Drawing.Point(128, 437);
            this.btn_dispense.Name = "btn_dispense";
            this.btn_dispense.Size = new System.Drawing.Size(185, 84);
            this.btn_dispense.TabIndex = 10;
            this.btn_dispense.Text = "Dispense";
            this.btn_dispense.UseVisualStyleBackColor = true;
            this.btn_dispense.Click += new System.EventHandler(this.btn_dispense_Click);
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Location = new System.Drawing.Point(195, 394);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(24, 17);
            this.lbl_money.TabIndex = 11;
            this.lbl_money.Text = "$0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 533);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.btn_dispense);
            this.Controls.Add(this.btn_2d);
            this.Controls.Add(this.btn_1d);
            this.Controls.Add(this.btn_50c);
            this.Controls.Add(this.btn_20c);
            this.Controls.Add(this.btn_10c);
            this.Controls.Add(this.btn_5c);
            this.Controls.Add(this.rbt_ginger);
            this.Controls.Add(this.rbt_coke);
            this.Controls.Add(this.rbt_llb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_llb;
        private System.Windows.Forms.RadioButton rbt_coke;
        private System.Windows.Forms.RadioButton rbt_ginger;
        private System.Windows.Forms.Button btn_5c;
        private System.Windows.Forms.Button btn_10c;
        private System.Windows.Forms.Button btn_20c;
        private System.Windows.Forms.Button btn_50c;
        private System.Windows.Forms.Button btn_1d;
        private System.Windows.Forms.Button btn_2d;
        private System.Windows.Forms.Button btn_dispense;
        private System.Windows.Forms.Label lbl_money;
    }
}

