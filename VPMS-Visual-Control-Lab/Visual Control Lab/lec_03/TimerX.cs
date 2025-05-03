using System;
using System.Drawing;
using System.Windows.Forms;

namespace Visual_Control_Lab.lec_03
{
    public partial class TimerX : UserControl
    {

        public string Title { get{ return label2.Text; } set { label2.Text = value; } }
        public bool AutoStart { get { return checkBox2.Checked; } set { checkBox2.Checked = value;  Start(); } }
        public bool OneTimeOnly { set { checkBox1.Checked = true; } }
        public int T { get { return Convert.ToInt16(numericUpDown1.Value); } set { numericUpDown1.Value = value; } }

        public void Start()
        {
            timer1.Interval = Convert.ToInt16(numericUpDown1.Value);
            button1.Enabled = false;
            button2.Enabled = true;
            label3.ForeColor = Color.YellowGreen;
            timer1.Start();
        }

        public void Stop()
        {
            button1.Enabled = true;
            button2.Enabled = false;
            label3.ForeColor = Color.Red;
            timer1.Stop();
        }


        public void Action()
        {
            OnClick(null);
        }




        #region تحكم الواجهة

        public TimerX()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt16(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label3.ForeColor == Color.YellowGreen)
            {
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.ForeColor = Color.YellowGreen;
            }

            if (checkBox1.Checked)
            {
                Stop();
            }

            Action();
        }

        #endregion
    }
}
