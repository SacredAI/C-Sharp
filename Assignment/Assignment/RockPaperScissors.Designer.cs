namespace Assignment
{
    partial class RockPaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RockPaperScissors));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_bet = new System.Windows.Forms.TextBox();
            this.lbl_money = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbx_com = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbx_ply = new System.Windows.Forms.PictureBox();
            this.btn_rock = new System.Windows.Forms.Button();
            this.btn_paper = new System.Windows.Forms.Button();
            this.btn_sissiors = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_com)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ply)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 299);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bet: $";
            // 
            // tbx_bet
            // 
            this.tbx_bet.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_bet.Location = new System.Drawing.Point(96, 335);
            this.tbx_bet.Name = "tbx_bet";
            this.tbx_bet.Size = new System.Drawing.Size(100, 48);
            this.tbx_bet.TabIndex = 3;
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_money.Location = new System.Drawing.Point(150, 392);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(69, 46);
            this.lbl_money.TabIndex = 4;
            this.lbl_money.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Money: $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Computer\'s Choice";
            // 
            // pbx_com
            // 
            this.pbx_com.Location = new System.Drawing.Point(351, 80);
            this.pbx_com.Name = "pbx_com";
            this.pbx_com.Size = new System.Drawing.Size(170, 157);
            this.pbx_com.TabIndex = 7;
            this.pbx_com.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "Your Choice";
            // 
            // pbx_ply
            // 
            this.pbx_ply.Location = new System.Drawing.Point(351, 289);
            this.pbx_ply.Name = "pbx_ply";
            this.pbx_ply.Size = new System.Drawing.Size(167, 158);
            this.pbx_ply.TabIndex = 9;
            this.pbx_ply.TabStop = false;
            // 
            // btn_rock
            // 
            this.btn_rock.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rock.Location = new System.Drawing.Point(572, 172);
            this.btn_rock.Name = "btn_rock";
            this.btn_rock.Size = new System.Drawing.Size(164, 54);
            this.btn_rock.TabIndex = 10;
            this.btn_rock.Text = "Rock";
            this.btn_rock.UseVisualStyleBackColor = true;
            this.btn_rock.Click += new System.EventHandler(this.btn_rock_Click);
            // 
            // btn_paper
            // 
            this.btn_paper.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paper.Location = new System.Drawing.Point(572, 232);
            this.btn_paper.Name = "btn_paper";
            this.btn_paper.Size = new System.Drawing.Size(164, 54);
            this.btn_paper.TabIndex = 13;
            this.btn_paper.Text = "Paper";
            this.btn_paper.UseVisualStyleBackColor = true;
            this.btn_paper.Click += new System.EventHandler(this.btn_paper_Click);
            // 
            // btn_sissiors
            // 
            this.btn_sissiors.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sissiors.Location = new System.Drawing.Point(572, 292);
            this.btn_sissiors.Name = "btn_sissiors";
            this.btn_sissiors.Size = new System.Drawing.Size(164, 54);
            this.btn_sissiors.TabIndex = 14;
            this.btn_sissiors.Text = "Scissors";
            this.btn_sissiors.UseVisualStyleBackColor = true;
            this.btn_sissiors.Click += new System.EventHandler(this.btn_sissiors_Click);
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 452);
            this.Controls.Add(this.btn_sissiors);
            this.Controls.Add(this.btn_paper);
            this.Controls.Add(this.btn_rock);
            this.Controls.Add(this.pbx_ply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbx_com);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.tbx_bet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RockPaperScissors";
            this.Text = "RockPaperSissors";
            this.Load += new System.EventHandler(this.RockPaperSissors_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_com)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_bet;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbx_com;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbx_ply;
        private System.Windows.Forms.Button btn_rock;
        private System.Windows.Forms.Button btn_paper;
        private System.Windows.Forms.Button btn_sissiors;
    }
}