using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K2Coursework
{
    public partial class Form1 : Form
    {
        List<Particle> particles = new List<Particle>();
        Emitter emitter;
        public int stoper;
        Color temp = Color.Black;


        public Form1()
        {
            InitializeComponent();
            canvas.Image = new Bitmap(canvas.Width, canvas.Height);

            emitter = new Emitter
            {
                Width = canvas.Width / 2,
                Heights = canvas.Height,

            };

        }

        private void starter_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 10;
            stoper = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (stoper)
            {
                case 0:
                    emitter.UpdateState();
                    break;
                case 1:
                    break;
                default:
                    break;
            }

            using (var g = Graphics.FromImage(canvas.Image))
            {
                g.Clear(Color.White);
                emitter.Render(g); 
            }

            canvas.Invalidate();

        }


        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            emitter.GravitationY = trackBar2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stoper = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void redColorBox_Click(object sender, EventArgs e)
        {
            temp = Color.Red;
        }

        private void greenColorBox_Click(object sender, EventArgs e)
        {
            temp = Color.Green;
        }

        private void yellowColorBox_Click(object sender, EventArgs e)
        {
            temp = Color.Yellow;
        }
        
    }
}
