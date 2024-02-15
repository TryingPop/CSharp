using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch05.Sub4;

namespace Ch05.Sub4
{
    internal class Truck : Car
    {
        private int capacity;

        public Truck(string name, string color, int speed, int capacity) : base(name, color, speed)
        {
            this.capacity = capacity;
        }

        public override void Show()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("차량명 : {0}", this.name);
            Console.WriteLine("차량색 : {0}", this.color);
            Console.WriteLine("현재속도 : {0}", this.speed);
            Console.WriteLine("적재량(톤) : {0}", this.capacity);
            Console.WriteLine("--------------");
        }
    }
}