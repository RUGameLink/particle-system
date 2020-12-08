using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K2Coursework
{
    public class Emitter
    {
        public List<Particle> particles = new List<Particle>();

        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();


        public int Width;
        public int Height;

        public int MousePositionX;
        public int MousePositionY;

        public float GravitationX = 0;
        public float GravitationY = 1;

        public int ParticlesPerTick = 10;

        public int SpeedMin = 1;
        public int SpeedMax = 10;

        public int Direction = 1;

        public int MinRad = 20;
        public int MaxRad = 140;

        public Color ColorFrom = Color.Blue;
        public Color ColorTo = Color.FromArgb(0, Color.Blue);

        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick;

            foreach (var particle in particles)
            {
                particle.Life -= 1;
                if (particle.Life <= 0)
                {
                    ResetParticle(particle);

                    if (particlesToCreate > 0)
                    {
                        particlesToCreate -= 1;
                        ResetParticle(particle);
                    }
                }
                else
                {
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;

                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }


                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;

                }
            }

            while (particlesToCreate >= 1)
            {
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle(particle);
                particles.Add(particle);
            }
        }

        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = Particle.rand.Next(100);
            particle.X = Width;
            particle.Y = Height;


            var direction = Direction + MinRad + (double)Particle.rand.Next(MaxRad);
            var speed = Particle.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * 4 * speed);

            particle.Radius = 2 + Particle.rand.Next(5);

            if (particle.Life > 0)
            {
                var color = particle as ParticleColorful;
                color.FromColor = ColorFrom;
                color.ToColor = ColorTo;
            }
        }

        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }

            foreach (var point in impactPoints)
            {
                point.Render(g);
            }
        }
        public virtual Particle CreateParticle()
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

            return particle;
        }
    }
}
