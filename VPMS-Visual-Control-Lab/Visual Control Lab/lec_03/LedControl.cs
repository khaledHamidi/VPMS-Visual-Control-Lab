using System.Windows.Forms;

namespace Visual_Control_Lab.lec_03
{
    public partial class LedControl : Form
    {
        public LedControl()
        {
            InitializeComponent();
        }

        private void led1_Click(object sender, System.EventArgs e)
        {

        }

        private void timerX2_Click(object sender, System.EventArgs e)
        {
            if (led2.state == true)
                led2.Off();
            else
                led2.On();
        }

        private void timerX1_Click(object sender, System.EventArgs e)
        {
            if (led1.state == true)
                led1.Off();
            else
                led1.On();
        }
    }
}
