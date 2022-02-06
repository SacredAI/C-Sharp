namespace WindowsFormsApplication2
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
            this.btnDoNotPress = new System.Windows.Forms.Button();
            this.rdoNerd = new System.Windows.Forms.RadioButton();
            this.rdoMemez = new System.Windows.Forms.RadioButton();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoNotPress
            // 
            this.btnDoNotPress.Location = new System.Drawing.Point(69, 12);
            this.btnDoNotPress.Name = "btnDoNotPress";
            this.btnDoNotPress.Size = new System.Drawing.Size(135, 55);
            this.btnDoNotPress.TabIndex = 0;
            this.btnDoNotPress.Text = "Do Not Press";
            this.btnDoNotPress.UseVisualStyleBackColor = true;
            this.btnDoNotPress.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoNerd
            // 
            this.rdoNerd.AutoSize = true;
            this.rdoNerd.Location = new System.Drawing.Point(12, 117);
            this.rdoNerd.Name = "rdoNerd";
            this.rdoNerd.Size = new System.Drawing.Size(80, 21);
            this.rdoNerd.TabIndex = 4;
            this.rdoNerd.TabStop = true;
            this.rdoNerd.Text = "NERD\'S";
            this.rdoNerd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoNerd.UseVisualStyleBackColor = true;
            // 
            // rdoMemez
            // 
            this.rdoMemez.AutoSize = true;
            this.rdoMemez.Location = new System.Drawing.Point(192, 117);
            this.rdoMemez.Name = "rdoMemez";
            this.rdoMemez.Size = new System.Drawing.Size(78, 21);
            this.rdoMemez.TabIndex = 5;
            this.rdoMemez.TabStop = true;
            this.rdoMemez.Text = "MEMEZ";
            this.rdoMemez.UseVisualStyleBackColor = true;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(189, 181);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 17);
            this.lblTest.TabIndex = 6;
            this.lblTest.MouseHover += new System.EventHandler(this.lblTest_Hover);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(50, 195);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.rdoMemez);
            this.Controls.Add(this.rdoNerd);
            this.Controls.Add(this.btnDoNotPress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoNotPress;
        private System.Windows.Forms.RadioButton rdoNerd;
        private System.Windows.Forms.RadioButton rdoMemez;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnTest;
    }
}

