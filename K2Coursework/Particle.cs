using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Coursework
{
    using System.Drawing;
    class Particle
    {
        public int Radius; // радиус частицы
        public float X; // X координата положения частицы в пространстве
        public float Y; // Y координата положения частицы в пространстве
        public float Life;

        public float SpeedX; // скорость перемещения по оси X
        public float SpeedY; // скорость перемещения по оси Y

        public static Random rand = new Random();

        public Particle()
        {

            var direction = (double)30 + Particle.rand.Next(120);
            var speed = 1 + Particle.rand.Next(7);

            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * 4 * speed);

            Radius = 2 + Particle.rand.Next(5);
            Life = 20 + Particle.rand.Next(60);
        }

        public void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 20);
            int alpha = (int)(k * 255);

            var color = Color.FromArgb(alpha, Color.Blue);
            var b = new SolidBrush(color);

            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            b.Dispose();
        }
    }
}
