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
            new Lec02().Show();             // فتح نافذة محاضرة2 وعرضها
        }


        #endregion
    }
}
