namespace Visual_Control_Lab.lec_03
{
    partial class Timer_Counter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timerX1 = new Visual_Control_Lab.lec_03.TimerX();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 80);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerX1
            // 
            this.timerX1.AutoStart = true;
            this.timerX1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.timerX1.Location = new System.Drawing.Point(193, 12);
            this.timerX1.Name = "timerX1";
            this.timerX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timerX1.Size = new System.Drawing.Size(218, 135);
            this.timerX1.TabIndex = 0;
            this.timerX1.Title = "العداد الأول";
            this.timerX1.Click += new System.EventHandler(this.timerX1_Validated);
            // 
            // Timer_Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 161);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.timerX1);
            this.Name = "Timer_Counter";
            this.Text = "Timer_Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Timer_Counter_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TimerX timerX1;
        private System.Windows.Forms.TextBox textBox1;
    }
}