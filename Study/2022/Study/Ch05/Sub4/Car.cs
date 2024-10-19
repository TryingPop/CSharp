using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Car
    {
        // 상속에서 자식클래스가 참조할 수 있도록 protected로 수정
        protected string name;
        protected string color;
        protected int speed;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public int Speed
        {
            get => speed;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Speed는 0보다 작을 수 없습니다.");
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public Car(string name, string color, int speed)
        {
            this.Name = name;
            this.Color = color;
            this.Speed = speed;

            Console.WriteLine("{0} 생성!", this.Name);
        }

        public void SpeedUp(int speed = 1)
        {
            this.Speed += speed;
        }

        public void SpeedDown(int speed = 1)
        {
            this.Speed -= speed;
        }

        public virtual void Show()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("차량명 : {0}", this.Name);
            Console.WriteLine("차량색 : {0}", this.Color);
            Console.WriteLine("현재속도 : {0}", this.Speed);
            Console.WriteLine("--------------");
        }
    }
}