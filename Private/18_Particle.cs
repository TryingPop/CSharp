using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.08.09
 * 내용 : Particle - 흩뿌리는 이벤트
 */

namespace Private
{
    internal class _18_Particle
    {
        static void Main18(string[] args)
        {

        }

        class ParticlePrinciple
        {
            List<float[]> particle = new List<float[]>();
            Random rand = new Random();

            public ParticlePrinciple()
            {
            }

            public void Emit()
            {
                if (particle != null)
                {
                    for (int i = 0; i < particle.Count; i++)
                    {
                        // move
                        this.particle[i][0] += this.particle[i][3];
                        this.particle[i][1] += this.particle[i][4];
                        this.particle[i][2] -= 0.5f;
                    }
                }
            }

            public void AddParticles()
            {
                float posX = 250;
                float posY = 250;
                float radius = 10;
                float directionX = rand.Next(-2, 3);
                float directionY = rand.Next(-2, 3);
                float[] Particle_circle = new float[] { posX, posY, radius, directionX, directionY };
                this.particle.Add(Particle_circle);
            }

            public void DeleteParticles()
            {
                for (int i = particle.Count - 1; i >= 0; i--)
                {
                    if (particle[i][2] <= 0)
                    {
                        particle.Remove(particle[i]);
                    }
                }
            }

            // winform에서 timer 문안에 SetParticle 을 넣어주면 된다.
            public void SetParticle() 
            {
                for (int i = 0; i < particle.Count; i++)
                {
                    Rectangle rect = new Rectangle(x: (int)this.particle[i][0], y: (int)this.particle[i][1], 
                                                   width: (int)(2 * this.particle[i][2]), height: (int)(2 * this.particle[i][2]));
                    this.Emit();
                    this.AddParticles();
                    this.DeleteParticles();
                }
            }
        }
    }
}

// 참고 영상
// https://www.youtube.com/watch?v=yfcsB3SGsKY