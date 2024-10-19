using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    internal class Truck : Car
    {
        private int capacity;

        public Truck(string name, string color, int speed, int capacity) : base(name, color, speed)
        {
            this.capacity = capacity;
        }

        public override void SpeedDown(int speed)
        {
            base.speed -= speed;
        }

        public override void SpeedUp(int speed)
        {
            base.speed += speed;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("적재용량 : {0}", this.capacity);
            Console.WriteLine("======================");
        }
    }
}
