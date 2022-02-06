namespace Sudoko
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
            this.components = new System.ComponentModel.Container();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_Answer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_GameLevel = new System.Windows.Forms.ComboBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Incorrect = new System.Windows.Forms.Button();
            this.btn_guides = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Location = new System.Drawing.Point(66, 70);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(106, 28);
            this.btn_NewGame.TabIndex = 8;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // btn_Answer
            // 
            this.btn_Answer.Location = new System.Drawing.Point(66, 107);
            this.btn_Answer.Name = "btn_Answer";
            this.btn_Answer.Size = new System.Drawing.Size(106, 28);
            this.btn_Answer.TabIndex = 9;
            this.btn_Answer.Text = "Show Answer";
            this.btn_Answer.Click += new System.EventHandler(this.btn_Answer_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Level:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbo_GameLevel
            // 
            this.cbo_GameLevel.Items.AddRange(new object[] {
            "Simple",
            "Medium",
            "Complex"});
            this.cbo_GameLevel.Location = new System.Drawing.Point(56, 33);
            this.cbo_GameLevel.Name = "cbo_GameLevel";
            this.cbo_GameLevel.Size = new System.Drawing.Size(116, 24);
            this.cbo_GameLevel.TabIndex = 10;
            this.cbo_GameLevel.Text = "Simple";
            this.cbo_GameLevel.SelectedIndexChanged += new System.EventHandler(this.cbo_GameLevel_SelectedIndexChanged);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.ColumnHeadersVisible = false;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DataGridView1.Location = new System.Drawing.Point(192, 61);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(304, 247);
            this.DataGridView1.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 25;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 25;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 25;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 25;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Width = 25;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Width = 25;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.Width = 25;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.Width = 25;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(192, 31);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(26, 23);
            this.btn_1.TabIndex = 15;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(224, 31);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(26, 23);
            this.btn_2.TabIndex = 16;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(256, 31);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(26, 23);
            this.btn_3.TabIndex = 17;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(288, 31);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(26, 23);
            this.btn_4.TabIndex = 18;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(320, 31);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(26, 23);
            this.btn_5.TabIndex = 19;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(352, 31);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(26, 23);
            this.btn_6.TabIndex = 20;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(384, 31);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(26, 23);
            this.btn_7.TabIndex = 21;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(416, 31);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(26, 23);
            this.btn_8.TabIndex = 22;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(448, 31);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(26, 23);
            this.btn_9.TabIndex = 23;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(1, 165);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(43, 17);
            this.time.TabIndex = 24;
            this.time.Text = "Time:";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(320, 1);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(58, 24);
            this.btn_clear.TabIndex = 25;
            this.btn_clear.Text = " Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Incorrect
            // 
            this.btn_Incorrect.Location = new System.Drawing.Point(56, 190);
            this.btn_Incorrect.Name = "btn_Incorrect";
            this.btn_Incorrect.Size = new System.Drawing.Size(116, 34);
            this.btn_Incorrect.TabIndex = 26;
            this.btn_Incorrect.Text = "Show Incorrect";
            this.btn_Incorrect.Click += new System.EventHandler(this.btn_Incorrect_Click);
            // 
            // btn_guides
            // 
            this.btn_guides.Location = new System.Drawing.Point(56, 230);
            this.btn_guides.Name = "btn_guides";
            this.btn_guides.Size = new System.Drawing.Size(116, 34);
            this.btn_guides.TabIndex = 28;
            this.btn_guides.Text = "Show Guides";
            this.btn_guides.Click += new System.EventHandler(this.btn_guides_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 334);
            this.Controls.Add(this.btn_guides);
            this.Controls.Add(this.btn_Incorrect);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.time);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.btn_Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_GameLevel);
            this.Name = "Form1";
            this.Text = "Sudoko";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_Answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_GameLevel;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Incorrect;
        private System.Windows.Forms.Button btn_guides;
    }
}

