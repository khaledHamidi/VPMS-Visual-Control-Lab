using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Visual_Control_Lab.Properties;

namespace Visual_Control_Lab
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer(Resources.startup); // ملف Resources.startup موجود في اعدادات المشروع
            player.Play();
            label1.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
        }


        #region الأحداث


        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Lec02().ShowDialog();             // فتح نافذة محاضرة2 وعرضها
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Lec02_2().ShowDialog();             // فتح نافذة محاضرة2 وعرضها
            Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            new Lec03().ShowDialog();             // فتح نافذة محاضرة3 وعرضها
            Show();
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 1 * 0.01;   //  this.Opacity = [ 0.00(0%) > 1.00(100%) ]
            if(this.Opacity >= 1)
            {
                timer1.Stop();
            }
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Gainsboro;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            // تحديد موقع مؤشر الماوس
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            // تحديد لون جديد بناءً على موقع الماوس
            Color color = Color.FromArgb(60,x % 256, y % 256, (x + y) % 256);

            // تغيير لون الزر
            (sender as Button).BackColor = color;
        }
    } 
}
