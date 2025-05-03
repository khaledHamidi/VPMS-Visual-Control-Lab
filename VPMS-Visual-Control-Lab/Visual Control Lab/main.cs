using System;
using System.Windows.Forms;

namespace Visual_Control_Lab
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
        }


        #region الأحداث


        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Lec02().ShowDialog();             // فتح نافذة محاضرة2 وعرضها
            Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            new Lec03().ShowDialog();             // فتح نافذة محاضرة3 وعرضها
            Show();
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Lec02_2().ShowDialog();             // فتح نافذة محاضرة2 وعرضها
            Show();
        }
    }
}
