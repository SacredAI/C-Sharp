namespace Assignment
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.btn_rps = new System.Windows.Forms.Button();
            this.btn_blackjack = new System.Windows.Forms.Button();
            this.btn_minesweeper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_rps
            // 
            this.btn_rps.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_rps.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_rps.Location = new System.Drawing.Point(39, 333);
            this.btn_rps.Name = "btn_rps";
            this.btn_rps.Size = new System.Drawing.Size(110, 80);
            this.btn_rps.TabIndex = 0;
            this.btn_rps.Text = "Rock, Paper, Scissors";
            this.btn_rps.UseVisualStyleBackColor = false;
            this.btn_rps.Click += new System.EventHandler(this.btn_rps_Click);
            this.btn_rps.MouseLeave += new System.EventHandler(this.btn_rps_Mouseleave);
            this.btn_rps.MouseHover += new System.EventHandler(this.btn_rps_Hover);
            // 
            // btn_blackjack
            // 
            this.btn_blackjack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_blackjack.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_blackjack.Location = new System.Drawing.Point(221, 333);
            this.btn_blackjack.Name = "btn_blackjack";
            this.btn_blackjack.Size = new System.Drawing.Size(110, 80);
            this.btn_blackjack.TabIndex = 1;
            this.btn_blackjack.Text = "BlackJack";
            this.btn_blackjack.UseVisualStyleBackColor = false;
            this.btn_blackjack.Click += new System.EventHandler(this.btn_blackjack_Click);
            this.btn_blackjack.MouseLeave += new System.EventHandler(this.btn_blackjack_Mouseleave);
            this.btn_blackjack.MouseHover += new System.EventHandler(this.btn_blackjack_Hover);
            // 
            // btn_minesweeper
            // 
            this.btn_minesweeper.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minesweeper.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_minesweeper.Location = new System.Drawing.Point(397, 333);
            this.btn_minesweeper.Name = "btn_minesweeper";
            this.btn_minesweeper.Size = new System.Drawing.Size(110, 80);
            this.btn_minesweeper.TabIndex = 2;
            this.btn_minesweeper.Text = "MineSweeper";
            this.btn_minesweeper.UseVisualStyleBackColor = false;
            this.btn_minesweeper.Click += new System.EventHandler(this.btn_minesweeper_Click);
            this.btn_minesweeper.MouseLeave += new System.EventHandler(this.btn_minesweeper_Mouseleave);
            this.btn_minesweeper.MouseHover += new System.EventHandler(this.btn_minesweeper_Hover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(139, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "PICK A GAME!!!";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_minesweeper);
            this.Controls.Add(this.btn_blackjack);
            this.Controls.Add(this.btn_rps);
            this.Name = "Form_Main";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rps;
        private System.Windows.Forms.Button btn_blackjack;
        private System.Windows.Forms.Button btn_minesweeper;
        private System.Windows.Forms.Label label1;
    }
}

