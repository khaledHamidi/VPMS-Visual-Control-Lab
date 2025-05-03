namespace Visual_Control_Lab.lec_03
{
    partial class LedControl
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
            this.timerX2 = new Visual_Control_Lab.lec_03.TimerX();
            this.timerX1 = new Visual_Control_Lab.lec_03.TimerX();
            this.led2 = new Visual_Control_Lab.lec_03.Led();
            this.led1 = new Visual_Control_Lab.lec_03.Led();
            this.SuspendLayout();
            // 
            // timerX2
            // 
            this.timerX2.AutoStart = true;
            this.timerX2.Location = new System.Drawing.Point(159, 177);
            this.timerX2.Name = "timerX2";
            this.timerX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timerX2.Size = new System.Drawing.Size(218, 132);
            this.timerX2.T = 300;
            this.timerX2.TabIndex = 3;
            this.timerX2.Title = "العداد الأول";
            this.timerX2.Click += new System.EventHandler(this.timerX2_Click);
            // 
            // timerX1
            // 
            this.timerX1.AutoStart = true;
            this.timerX1.Location = new System.Drawing.Point(159, 21);
            this.timerX1.Name = "timerX1";
            this.timerX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.timerX1.Size = new System.Drawing.Size(218, 132);
            this.timerX1.T = 100;
            this.timerX1.TabIndex = 2;
            this.timerX1.Title = "العداد الأول";
            this.timerX1.Click += new System.EventHandler(this.timerX1_Click);
            // 
            // led2
            // 
            this.led2.BackColor = System.Drawing.Color.Sienna;
            this.led2.Color = System.Drawing.Color.Sienna;
            this.led2.Location = new System.Drawing.Point(50, 213);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(72, 57);
            this.led2.state = false;
            this.led2.TabIndex = 1;
            // 
            // led1
            // 
            this.led1.BackColor = System.Drawing.Color.RoyalBlue;
            this.led1.Color = System.Drawing.Color.RoyalBlue;
            this.led1.Location = new System.Drawing.Point(50, 46);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(72, 61);
            this.led1.state = false;
            this.led1.TabIndex = 0;
            this.led1.Click += new System.EventHandler(this.led1_Click);
            // 
            // LedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 337);
            this.Controls.Add(this.timerX2);
            this.Controls.Add(this.timerX1);
            this.Controls.Add(this.led2);
            this.Controls.Add(this.led1);
            this.Name = "LedControl";
            this.Text = "LedControl";
            this.ResumeLayout(false);

        }

        #endregion

        private Led led1;
        private Led led2;
        private TimerX timerX1;
        private TimerX timerX2;
    }
}