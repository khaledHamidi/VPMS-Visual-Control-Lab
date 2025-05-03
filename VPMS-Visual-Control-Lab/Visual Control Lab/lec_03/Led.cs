using System.Drawing;
using System.Windows.Forms;

namespace Visual_Control_Lab.lec_03
{
    public partial class Led : UserControl
    {



        // LED 
        // On, Off, Color

        private Color _color = Color.Red;

        public Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                BackColor = value;
            }
        }

        public void On()
        {
            BackColor = Color;
            state = true;
        }
        public void Off()
        {
            BackColor = Color.Black;
            state = false;
        }


        public bool state { get; set; }


        public Led()
        {
            InitializeComponent();
        }
    }
}
