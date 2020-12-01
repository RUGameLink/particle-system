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
        public bool start;
        Emitter emitter;

        PaintPoint point1;


        public Form1()
        {
            InitializeComponent();

            emitter = new Emitter
            {
                Width = canvas.Width / 2,
                Height = canvas.Height,
                GravitationY = 1
            };

            canvas.Image = new Bitmap(canvas.Width, canvas.Height);

            point1 = new PaintPoint
            {
                X = (float)(canvas.Width / 4),
                Y = canvas.Height - 70,
                RoundColor = Color.Black
            };

            // антигравитон
            //       emitter.impactPoints.Add(new AntiGravityPoint
            //      {
            //          X = canvas.Width / 2,
            //          Y = canvas.Height / 2
            //      });
            /*
                        //  гравитон
                        emitter.impactPoints.Add(new PaintPoint
                        {
                            X = (float)(canvas.Width * 0.75),
                            Y = canvas.Height / 2
                        });
            */
            emitter.impactPoints.Add(point1);

            trackBar1.Minimum = 55;
            trackBar1.Maximum = canvas.Width - 50;
        }

        private void startBut_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            start = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (start == true)
            {
                emitter.UpdateState();
            }
            else
            {

            }

            using (var g = Graphics.FromImage(canvas.Image))
            {
                g.Clear(Color.White);
                emitter.Render(g);
            }


            canvas.Invalidate();
        }
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            emitter.GravitationY = trackBar2.Value;
        }

        private void minSpeed_Scroll(object sender, EventArgs e)
        {
            emitter.SpeedMin = minSpeed.Value;
        }

        private void maxSpeed_Scroll(object sender, EventArgs e)
        {
            emitter.SpeedMax = maxSpeed.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            point1.X = trackBar1.Value;
        }

        private void stopBut_Click(object sender, EventArgs e)
        {
            start = false;
        }

        private void redColorBox_Click(object sender, EventArgs e)
        {
            point1.RoundColor = Color.Red;
        }

        private void greenColorBox_Click(object sender, EventArgs e)
        {
            point1.RoundColor = Color.Green;
        }

        private void pinkColorBox_Click(object sender, EventArgs e)
        {
            point1.RoundColor = Color.HotPink;
        }

        private void blueColorBox_Click(object sender, EventArgs e)
        {
            point1.RoundColor = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
