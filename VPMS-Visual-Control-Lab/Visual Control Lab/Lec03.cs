using System;
using System.Media;
using System.Windows.Forms;
using Visual_Control_Lab.Properties;

namespace Visual_Control_Lab
{
    public partial class Lec03 : Form
    {
        public Lec03()
        {
            InitializeComponent();
            richTextBox1.Text = "1. تصميم الواجهة. 2. ربط بالمتحكم. 3. تسليم المشروع";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            new lec_03.Timer_Counter().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new lec_03.LedControl().Show();
        }

















        #region جدول المهام اليومية

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string discription = richTextBox1.Text;
            string note = title + discription;
            listBox1.Items.Add(note);
        }

        #endregion























        #region ساعة إقاف

        private int tenths = 0; // كل 0.1 ثانية
        private int seconds = 0;
        private int minutes = 0;
        private int hours = 0;


        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        // تصفير العداد
        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            hours = minutes = seconds = tenths = 0;
            label3.Text = "00:00:00.0";

        }

        // حساب الزمن وعرضه كل 100 ميليثانية
        private void timer1_Tick(object sender, EventArgs e)
        {
            tenths++;

            // عند بلوغ 100 ميلي يتم إضافة 1 للثواني وتصفير الميلي
            if (tenths >= 10)
            {
                tenths = 0;
                seconds++;

                // عند بلوغ 60 ثانية يتم إضافة 1 للدقائق وتصفير الثواني ...
                if (seconds >= 60)
                {
                    seconds = 0;
                    minutes++;

                    if (minutes >= 60)
                    {
                        minutes = 0;
                        hours++;
                    }
                }
            }

            label3.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}.{tenths}";
            /* 
             * :D2 تعني نسخ على خانتي رقم 
             * مثلاً: لو كان الرقم 4 سيتم وضع صفر على يساره ليكون 05.
            */
        }

        #endregion
















        #region مؤقت زمني + تنبيه صوتي

        private void button10_Click(object sender, EventArgs e)
        {
            int sec = Convert.ToInt32(textBox2.Text);
            if (sec > 0)
            {
                timer2.Enabled = true;
            }
            else
            {
                MessageBox.Show("أخل عدد صحيح.");
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int sec = Convert.ToInt32(textBox2.Text);
            sec = sec - 1;
            textBox2.Text = sec.ToString("D2"); // D2 >> 01 02 03 22 99 لتنسيق الخرج على انه رقمين
            //SystemSounds.Beep.Play(); // إدصار صوت بيب 
            Console.Beep();
            if (sec == 0)
            {
                timer2.Enabled = false;

                // تشغيل صوت
                SoundPlayer player = new SoundPlayer(Resources.timeisup1); // ملف Resources.timeisup1 موجود في اعدادات المشروع
                player.Play();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
        #endregion

    }
}
