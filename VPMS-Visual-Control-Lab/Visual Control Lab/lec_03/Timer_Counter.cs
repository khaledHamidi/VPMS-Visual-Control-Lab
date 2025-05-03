using System;
using System.Windows.Forms;

namespace Visual_Control_Lab.lec_03
{
    public partial class Timer_Counter : Form
    {
        public Timer_Counter()
        {
            InitializeComponent();
        }

        private void timerX1_Validated(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToInt16(textBox1.Text) + 1 ).ToString();
        }

        private void Timer_Counter_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerX1.Stop();
        }
    }
}
