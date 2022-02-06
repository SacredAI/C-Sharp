namespace GlobalVaribles
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
            this.lbl_number = new System.Windows.Forms.Label();
            this.btn_minus10 = new System.Windows.Forms.Button();
            this.btn_plus5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Location = new System.Drawing.Point(110, 82);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(24, 17);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "50";
            // 
            // btn_minus10
            // 
            this.btn_minus10.Location = new System.Drawing.Point(31, 154);
            this.btn_minus10.Name = "btn_minus10";
            this.btn_minus10.Size = new System.Drawing.Size(75, 23);
            this.btn_minus10.TabIndex = 1;
            this.btn_minus10.Text = "-10";
            this.btn_minus10.UseVisualStyleBackColor = true;
            this.btn_minus10.Click += new System.EventHandler(this.btn_minus10_Click);
            // 
            // btn_plus5
            // 
            this.btn_plus5.Location = new System.Drawing.Point(169, 154);
            this.btn_plus5.Name = "btn_plus5";
            this.btn_plus5.Size = new System.Drawing.Size(75, 23);
            this.btn_plus5.TabIndex = 2;
            this.btn_plus5.Text = "+5";
            this.btn_plus5.UseVisualStyleBackColor = true;
            this.btn_plus5.Click += new System.EventHandler(this.btn_plus5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btn_plus5);
            this.Controls.Add(this.btn_minus10);
            this.Controls.Add(this.lbl_number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Button btn_minus10;
        private System.Windows.Forms.Button btn_plus5;
    }
}

