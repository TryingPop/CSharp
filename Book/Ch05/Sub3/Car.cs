using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub3
{
    internal class Car
    {
        // 메서드 + 속성 수 = 멤버 수
        // 속성(필드)
        private string name;
        private string color;
        private int speed;

        private static int count;

        // Getter와 Setter
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

        // 생성할 때 실생되는 메서드
        // def self.__init__(self)와 같다

        // 오버로딩
        public Car()
        {
            Car.count++;
        }

        public Car(string name, string color, int speed)
        {
            this.Name = name;
            this.Color = color;
            this.Speed = speed;
            Car.count++;

            Console.WriteLine("{0} 생성!", this.Name);
        }

        /*
        Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color = color;
            this.speed = speed;
        }
        */

        // 기능(메서드) 
        // 여기선 static에 저장 X!
        // 차량 속도 조절(올리기)
        public void SpeedUp(int speed = 1)
        {
            this.Speed += speed;
        }

        // 차량 속도 조절(내리기)
        public void SpeedDown(int speed = 1)
        {
            this.Speed -= speed;
        }

        // 클래스 변수 name, color, speed를 보여준다
        public void Show()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("차량명 : {0}", this.Name);
            Console.WriteLine("차량번호 : {0}", Car.count);
            Console.WriteLine("차량색 : {0}", this.Color);
            Console.WriteLine("현재속도 : {0}", this.Speed);
            Console.WriteLine("--------------");
        }

    }
}