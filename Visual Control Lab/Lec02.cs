using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Control_Lab
{
    public partial class Lec02 : Form
    {



        public Lec02()
        {
            InitializeComponent();
            richTextBox1.AppendText("مرحباً بك في المحاضرة الثانية" + Environment.NewLine);
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText(); // مسح النص
        }









        #region التحكم في النافذة

        // تصغير النافذة
        private void button5_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized; // تصغير النافذة
        }


        //   إغلاق البرنامج مباشر
        private void button7_Click(object sender, EventArgs e)
        {
            //   إغلاق البرنامج مباشر

            Application.Exit();   // طريقة 1    

            // إغلاق بعد3 ثواني
            Task.Delay(3000).ContinueWith(t =>
            {
                Application.Exit();
            });

        }

        // إغلاق النافذة 
        private void button6_Click(object sender, EventArgs e)
        {
            Close(); // إغلاق النافذة الحالية

            // أو
            this.Close(); // إغلاق النافذة الحالية

            // this تستخدم للإشارة إلى النافذة الحالية
        }





        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized; // تكبير النافذة
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Size = new Size(309, 696); // تغيير حجم النافذة
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Size = new Size(1184, 738); // تغيير حجم النافذة

        }




        #endregion


        #region حساب مساحة


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                // حساب المساحة
                double L = double.Parse(textBox2.Text); // تحويل النص إلى عدد صحيح
                double area = L * L; // حساب المساحة
                label4.Text = area.ToString(); // عرض المساحة في الـ TextBox


            }
            catch
            {
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // حساب المساحة مع تنسيق الخرج
            double L = double.Parse(textBox3.Text); // تحويل النص إلى عدد صحيح
            double area = L * L; // حساب المساحة


            label6.Text = $" مساحة المربع= {area}"; // عرض المساحة بتنسيق 

            // أو
            label6.Text = "=مساحة المربع" + area.ToString(); // عرض المساحة بتنسيق نصي

            // تنسييق أخر

            label6.Text = $" مساحة المربع= {area:F2}"; // عرض المساحة بتنسيق رقمين عشريين


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // maskedtextbox2 دخل 
            // maskedtextbox1 خرج

            // تحويل النص إلى عدد صحيح
            double L = double.Parse(maskedTextBox2.Text); // تحويل النص إلى عدد صحيح
            double area = L * L; // حساب المساحة
            maskedTextBox1.Text = area.ToString(); // عرض المساحة في الـ TextBox
        }

        #endregion

        #region  Try-catch  / التحقق من عون المدخلات

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                // تحويل النص إلى عدد صحيح

                int x;

                int.Parse(textBox4.Text);                      // طريقة 1
                x = Convert.ToInt32(textBox4.Text);            // طريقة 2
                label9.Text = x.ToString();
            }
            catch
            {
                label9.Text = ("خطأ في تحويل النص إلى عدد صحيح");                                  // طريقة 1
                richTextBox1.AppendText("خطأ في تحويل النص إلى عدد صحيح" + Environment.NewLine);    // طريقة 2
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            // محاولة معرفو نوع البيانات المدخلة
            bool resault = int.TryParse(textBox5.Text, out int x); // محاولة تحويل النص إلى عدد صحيح

            if (resault == true)
            {
                // إذا كانت العملية ناجحة
                MessageBox.Show("المدخل هو عدد صحيح");

                // عرض العد
                label11.Text = $"العدد المدخل هو {x}";
            }
            else
            {
                // إذا كانت العملية فاشلة
                MessageBox.Show("المدخل ليس عدد صحيح");
            }
        }


        #endregion


        #region لوحة انظر للكود

        private void button11_Click(object sender, EventArgs e)
        {
            // جميع عدد مع نص 

            string Name_age = "الأسم احمد، العمر" + 25.ToString();
            // أو
            string Name_age2 = "الأسم احمد، العمر" + (2025 - 1999).ToString();
            // أو
            string Name_age3 = "الأسم احمد، العمر" + (2025 - 1999); // بدون تحويل
            // أو
            double a = 4, b = 5, c = 7;
            string size = $"The Size of box is : {a * b * c}";

            // تحويل من نص إلى اعداد وغيرها 

            string age = "152";

            int age1 = int.Parse(age); // تحويل النص إلى عدد صحيح
            // أو
            int age2 = Convert.ToInt32(age); // تحويل النص إلى عدد صحيح
            // أو
            int age3 = int.TryParse(age, out int x) ? x : 0; // محاولة تحويل النص إلى عدد صحيح

            // يمكن استبدال int بأي نوع متحول 

            string text = "True";
            bool isTrue = bool.Parse(text); // تحويل النص إلى قيمة منطقية

            text = "نص غير صحيح لا يمكن تحويله إلى Ture أو False";

            if (bool.TryParse(text, out bool value))
            {
                MessageBox.Show($"الحالة: {value}");
            }
            else
            {
                MessageBox.Show("ليست من نوع صحيح * لا يمكن التحويل");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region لوحة التعامل مع النصوص

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                try
                {
                    // name, lastname
                    // الاسم، اللقب
                    string[] fullname = textBox6.Text.Split(' '); // تقسيم النص إلى أجزاء
                    string name = fullname[0]; // الاسم
                    string lastname = fullname[1]; // اللقب
                    MessageBox.Show($"الاسم: {name} {Environment.NewLine}" +
                                   $" الكنية: {lastname}"
                                   );

                }
                catch
                {
                    MessageBox.Show("خطأ في تقسيم النص"); // عرض رسالة خطأ
                }


            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                // تحويل النص إلى مصفوفة من الأعداد
                string[] data = textBox6.Text.Split(','); // تقسيم النص إلى أجزاء

                int[] numbers = new int[data.Length]; // إنشاء مصفوفة جديدة


                for (int i = 0; i < data.Length; i++)
                {
                    // تحويل النص إلى عدد صحيح
                    if (int.TryParse(data[i], out int number))
                    {
                        numbers[i] = number; // تخزين العدد في المصفوفة
                        MessageBox.Show("الأعداد المدخلة صحيحة، تم تحويلها إلى مصفوفة اعداد");

                    }
                    else
                    {
                        MessageBox.Show($"'{data[i]}' ليس عدد صحيح");
                        return;
                    }
                }

            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            // محاول إجاد كلمة او جزء من نص 
            bool resault = textBox6.Text.Contains("تعمل"); // محاولة إيجاد الكلمة في النص
            if (resault == true)
            {
                // إذا كانت العملية ناجحة
                MessageBox.Show("الكلمة موجودة في النص");
            }
            else
            {
                // إذا كانت العملية فاشلة
                MessageBox.Show("الكلمة غير موجودة في النص");
            }
        }

        #endregion  

        #region التحكم في الكرة

        int step = 5; // خطوة الحركة

        // ضبط الخطوة 
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            step = (int)numericUpDown1.Value; // تغيير قيمة الخطوة
        }


        // تحريك الكرة لأعلى
        private void button15_Click(object sender, EventArgs e)
        {
            ball.Top = Math.Max(0, ball.Top - step);
        }


        // تحريك الكرة لأسفل
        private void button16_Click_1(object sender, EventArgs e)
        {
            ball.Top = Math.Min(ballPanel.Height - ball.Height, ball.Top + step);
        }


        // تحريك الكرة لليمين
        private void button14_Click(object sender, EventArgs e)
        {
            ball.Left = Math.Min(ballPanel.Width - ball.Width, ball.Left + step); // تحريك الكرة لليمين
        }


        // حركة لليمين

        private void button14_Click_1(object sender, EventArgs e)
        {
            ball.Left = Math.Min(ballPanel.Width - ball.Width, ball.Left + step);

        }

        // حركة لليسار
        private void button12_Click_1(object sender, EventArgs e)
        {

            ball.Left = Math.Max(0, ball.Left - step);

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            // حركة للأعلى–يمين
            ball.Top = Math.Max(0, ball.Top - step);
            ball.Left = Math.Min(ballPanel.Width - ball.Width, ball.Left + step);
        }


        #endregion

        #region تحديث نلقاءث عند إدخال نص

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label15.Text = textBox7.Text; // عرض النص
        }

        #endregion

        #region التنفيذ عند النقر على اي زر بالكيبورد

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            // Esc to clear , Enter to print

            if (e.KeyCode == Keys.Escape)
            {
                textBox8.Clear(); // مسح النص
            }
            else if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(textBox8.Text); // عرض النص في الـ RichTextBox
            }
            else if (e.KeyCode == Keys.Z || e.KeyCode == Keys.Q) //  حذف الحرف إذا كان
            {
                e.SuppressKeyPress = true; // Suppress the key press event  
            }
        }

        #endregion


    }
}
