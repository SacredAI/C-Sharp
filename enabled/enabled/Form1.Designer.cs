namespace enabled
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
            this.btn_click1 = new System.Windows.Forms.Button();
            this.btn_click2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btn_reset = new System.Windows.Forms.Button();
            this.cbx_enable = new System.Windows.Forms.CheckBox();
            this.cbx_disable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_click1
            // 
            this.btn_click1.Location = new System.Drawing.Point(63, 223);
            this.btn_click1.Name = "btn_click1";
            this.btn_click1.Size = new System.Drawing.Size(75, 23);
            this.btn_click1.TabIndex = 0;
            this.btn_click1.Text = "click1";
            this.btn_click1.UseVisualStyleBackColor = true;
            this.btn_click1.Click += new System.EventHandler(this.btn_click1_Click);
            // 
            // btn_click2
            // 
            this.btn_click2.Location = new System.Drawing.Point(252, 223);
            this.btn_click2.Name = "btn_click2";
            this.btn_click2.Size = new System.Drawing.Size(75, 23);
            this.btn_click2.TabIndex = 1;
            this.btn_click2.Text = "click2";
            this.btn_click2.UseVisualStyleBackColor = true;
            this.btn_click2.Click += new System.EventHandler(this.btn_click2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(143, 91);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(143, 118);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(143, 145);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(159, 287);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // cbx_enable
            // 
            this.cbx_enable.AutoSize = true;
            this.cbx_enable.Location = new System.Drawing.Point(346, 118);
            this.cbx_enable.Name = "cbx_enable";
            this.cbx_enable.Size = new System.Drawing.Size(74, 21);
            this.cbx_enable.TabIndex = 6;
            this.cbx_enable.Text = "Enable";
            this.cbx_enable.UseVisualStyleBackColor = true;
            // 
            // cbx_disable
            // 
            this.cbx_disable.AutoSize = true;
            this.cbx_disable.Location = new System.Drawing.Point(346, 145);
            this.cbx_disable.Name = "cbx_disable";
            this.cbx_disable.Size = new System.Drawing.Size(77, 21);
            this.cbx_disable.TabIndex = 7;
            this.cbx_disable.Text = "Disable";
            this.cbx_disable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 373);
            this.Controls.Add(this.cbx_disable);
            this.Controls.Add(this.cbx_enable);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btn_click2);
            this.Controls.Add(this.btn_click1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_click1;
        private System.Windows.Forms.Button btn_click2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.CheckBox cbx_enable;
        private System.Windows.Forms.CheckBox cbx_disable;
    }
}

