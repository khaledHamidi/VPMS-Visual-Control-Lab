using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Control_Lab
{
    public partial class Lec02_2 : Form
    {
        public Lec02_2()
        {
            InitializeComponent();
            comboBox3.SelectedIndex = 3;
         }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Visible = false;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Visible = true;

        }

        private void button1_MouseDown(object sender, EventArgs e)
        {
            button1.Visible = false;

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {


        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
         }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            // تحديد موقع مؤشر الماوس
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            // تحديد لون جديد بناءً على موقع الماوس
            Color color = Color.FromArgb(x % 256, y % 256, (x + y) % 256);
            // تغيير لون الزر
            button2.BackColor = color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(); // فتح نافذة اختيار اللون
            // تعيين لون الخلفية للزر إلى اللون المحدد
            button3.BackColor = colorDialog1.Color;
        }

        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // معرفة الأرتفاع المطلوب

            // العملية بسيطة
            // زيادة ارتفاع اصورة بقدر زيادة المطلوبة فقط. 
            // الصورة سوف تكبر بتجاه الأسفل بالتالي نحتاج إلى عكس ذلك



            // الصورة تحديد قيمها
            int max = 136; // at 100% 
            int min = 10; // at 0%
            int y_location_of_picture = 52; 
            int value = trackBar1.Value * (max- min) / 100; // تحديد قيمة الارتفاع المطلوبة
            // تغير  ارتفاع

            pictureBox4.Size = new Size(pictureBox4.Size.Width,  value);
            label3.Text = trackBar1.Value + "%";


            pictureBox4.Location = new Point(pictureBox4.Location.X, y_location_of_picture + (max - value));
        }
    }
}
