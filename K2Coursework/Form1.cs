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

        Color BGColor = Color.White;

        PaintPoint point1;
        PaintPoint patriotpoint1;
        PaintPoint patriotpoint2;
        PaintPoint patriotpoint3;




        public Form1()
        {
            InitializeComponent();

            emitter = new Emitter
            {
                Width = canvas.Width / 2,
                Height = canvas.Height,
                GravitationY = 1,
                ParticlesPerTick = 10
            };

            canvas.Image = new Bitmap(canvas.Width, canvas.Height);

            point1 = new PaintPoint
            {
                X = (float)(canvas.Width / 4),
                Y = canvas.Height - 70,
                RoundColor = Color.Black
            };

            this.MouseWheel += new MouseEventHandler(this_MouseWheel);

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

        void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                point1.Power += 5;
            else
                point1.Power -= 5;
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
                g.Clear(BGColor);
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
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                point1.RoundColor = colorDialog.Color;
                redColorBox.BackColor = colorDialog.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(trackBar3.Value == 1)
            {
                BGColor = Color.Black;

                patriotpoint1 = new PaintPoint
                {
                    X = (float)(canvas.Width / 2),
                    Y = canvas.Height - 80,
                    RoundColor = Color.Red
                };
                emitter.impactPoints.Add(patriotpoint1);

                patriotpoint2 = new PaintPoint
                {
                    X = (float)(canvas.Width / 2),
                    Y = canvas.Height - 320,
                    RoundColor = Color.White,
                    Power = 140
                };
                emitter.impactPoints.Add(patriotpoint2);

                patriotpoint3 = new PaintPoint
                {
                    X = (float)(canvas.Width / 2),
                    Y = canvas.Height - 190,
                    RoundColor = Color.Blue
                };
                emitter.impactPoints.Add(patriotpoint3);
                emitter.ParticlesPerTick = 20;
                emitter.SpeedMax = 20;
                emitter.MinRad = 40;
                emitter.MaxRad = 100;
            }
            else
            {
                BGColor = Color.White;
                emitter.impactPoints.Remove(patriotpoint1);
                emitter.impactPoints.Remove(patriotpoint2);
                emitter.impactPoints.Remove(patriotpoint3);
                emitter.ParticlesPerTick = 10;
                emitter.SpeedMax = maxSpeed.Value;
                emitter.MinRad = 20;
                emitter.MaxRad = 140;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            emitter.UpdateState();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = trackBar4.Value;
            label10.Text = $"Количество чaстиц: {emitter.ParticlesPerTick}";
        }
    }
}
