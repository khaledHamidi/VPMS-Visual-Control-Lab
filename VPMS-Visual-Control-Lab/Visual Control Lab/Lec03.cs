using System;
using System.Windows.Forms;

namespace Visual_Control_Lab
{
    public partial class Lec03 : Form
    {
        public Lec03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new lec_03.Timer_Counter().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new lec_03.LedControl().Show();

        }
    }
}
