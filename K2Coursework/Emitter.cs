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

        public int Heights; //Высот
        public int Width; //ширин
        public void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1; 
                if (particle.Life < 0)
                {

                    particle.Life = 20 + Particle.rand.Next(60);

                    particle.X = Width;
                    particle.Y = Heights;

                    particle.Radius = 2 + Particle.rand.Next(5);

                    var direction = (double)30 + Particle.rand.Next(120);
                    var speed = 1 + Particle.rand.Next(7);

                    particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
                    particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * 4 * speed);


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
                if (particles.Count < 500)
                {
                    var particle = new Particle();

                    particle.X = Width;
                    particle.Y = Heights;

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
    }
}
