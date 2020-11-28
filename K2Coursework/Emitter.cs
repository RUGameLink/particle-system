using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Coursework
{
    class Emitter
    {
        List<Particle> particles = new List<Particle>();
        public float GravitationX = 0;
        public float GravitationY = 1;

        public Color ColorFrom = Color.Blue; // начальный цвет частицы
        public Color ColorTo = Color.FromArgb(0, Color.Black); // конечный цвет частиц

        public int Heights; //Высот
        public int Width; //ширин

        public int MinSpeed = 1;
        public int MaxSpeed = 7;

        public int ParticlesCount = 500;

        public virtual Particle CreateParticle()
        {
            var particle = new Particle.ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

            return particle;
        }

        public void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1; 
                if (particle.Life < 0)
                {
                    ResetParticle(particle);
                }
                else
                {
                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;

                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;
                }
            }

            for (var i = 0; i < 10; ++i)
            {
                if (particles.Count < ParticlesCount)
                {
                    var particle = CreateParticle();

                    particle.X = Width;
                    particle.Y = Heights;

                    ResetParticle(particle);
                    particles.Add(particle);
                }
                else
                {
                    break;
                }
            }
        }

        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }

        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = 20 + Particle.rand.Next(60);

            particle.X = Width;
            particle.Y = Heights;

            particle.Radius = 2 + Particle.rand.Next(5);

            var direction = (double)30 + Particle.rand.Next(120);
            var speed = MinSpeed + Particle.rand.Next(MaxSpeed);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * 4 * speed);
        }
    }
}
