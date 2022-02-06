namespace WindowsFormsApplication3
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
            this.txb_input_1 = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.lbl_option_1 = new System.Windows.Forms.Label();
            this.lbl_input_2 = new System.Windows.Forms.Label();
            this.txb_input_2 = new System.Windows.Forms.TextBox();
            this.btn_hol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_input_1
            // 
            this.txb_input_1.Location = new System.Drawing.Point(134, 92);
            this.txb_input_1.Name = "txb_input_1";
            this.txb_input_1.Size = new System.Drawing.Size(100, 22);
            this.txb_input_1.TabIndex = 0;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(54, 194);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 1;
            this.btn_check.Text = "Add";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lbl_option_1
            // 
            this.lbl_option_1.AutoSize = true;
            this.lbl_option_1.Location = new System.Drawing.Point(51, 92);
            this.lbl_option_1.Name = "lbl_option_1";
            this.lbl_option_1.Size = new System.Drawing.Size(70, 17);
            this.lbl_option_1.TabIndex = 2;
            this.lbl_option_1.Text = "Number 1";
            // 
            // lbl_input_2
            // 
            this.lbl_input_2.AutoSize = true;
            this.lbl_input_2.Location = new System.Drawing.Point(51, 140);
            this.lbl_input_2.Name = "lbl_input_2";
            this.lbl_input_2.Size = new System.Drawing.Size(70, 17);
            this.lbl_input_2.TabIndex = 3;
            this.lbl_input_2.Text = "Number 2";
            // 
            // txb_input_2
            // 
            this.txb_input_2.Location = new System.Drawing.Point(134, 137);
            this.txb_input_2.Name = "txb_input_2";
            this.txb_input_2.Size = new System.Drawing.Size(100, 22);
            this.txb_input_2.TabIndex = 4;
            // 
            // btn_hol
            // 
            this.btn_hol.Location = new System.Drawing.Point(175, 194);
            this.btn_hol.Name = "btn_hol";
            this.btn_hol.Size = new System.Drawing.Size(75, 23);
            this.btn_hol.TabIndex = 5;
            this.btn_hol.Text = "HIgher?";
            this.btn_hol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btn_hol);
            this.Controls.Add(this.txb_input_2);
            this.Controls.Add(this.lbl_input_2);
            this.Controls.Add(this.lbl_option_1);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txb_input_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_input_1;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label lbl_option_1;
        private System.Windows.Forms.Label lbl_input_2;
        private System.Windows.Forms.TextBox txb_input_2;
        private System.Windows.Forms.Button btn_hol;
    }
}

