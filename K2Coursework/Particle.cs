using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Coursework
{
    public class Particle
    {
        public int Radius;
        public float X;
        public float Y;

        public float SpeedX;
        public float SpeedY;

        public float Life;

        public static Random rand = new Random();


        public Particle()
        {
            var direction = (double)rand.Next(360);
            var speed = 1 + rand.Next(10);

            SpeedX = rand.Next(360);
            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = 2 + rand.Next(10);
            Life = 20 + rand.Next(100);
        }

        public virtual void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100);
            int alpha = (int)(k * 255);

            var color = Color.FromArgb(alpha, Color.Black);
            var b = new SolidBrush(color);

            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            b.Dispose();
        }
    }

    public class ParticleColorful : Particle
    {
        public Color FromColor;
        public Color ToColor;

        public static Color MixColor(Color color1, Color color2, float k)
        {
            return Color.FromArgb(
                (int)(color2.A * k + color1.A * (1 - k)),
                (int)(color2.R * k + color1.R * (1 - k)),
                (int)(color2.G * k + color1.G * (1 - k)),
                (int)(color2.B * k + color1.B * (1 - k))
            );
        }

        public override void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100);

            var color = MixColor(ToColor, FromColor, k);
            var b = new SolidBrush(color);

            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            b.Dispose();
        }
    }

    public abstract class IImpactPoint
    {
        public float X;
        public float Y;
        public Color RoundColor;

        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }

    public class PaintPoint : IImpactPoint //круг-зaкрaшивaтель
    {
        public int Power = 100;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);

            if (r + particle.Radius < Power / 2)
            {
                var color = particle as ParticleColorful;
                color.FromColor = RoundColor;
                color.ToColor = RoundColor;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(RoundColor, 5),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
    }

    public class CounterPoint : IImpactPoint //круг-убийцa
    {
        public int Power = 100;
        int count = 0;

        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY);
            
            if (r + particle.Radius < Power / 2)
            {
                count ++;
                particle.Life = 0;
                var color = particle as ParticleColorful;
                color.FromColor = Color.Gold;
                color.ToColor = Color.Gold;
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(Color.Red, 5),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );

            g.DrawString(
            $"Я убил {count} \n чaстиц\nсегодня",
            new Font("Verdana", 10),
            new SolidBrush(Color.Black), 
            X - 25,
            Y - 10
            );
        }
    }
}
