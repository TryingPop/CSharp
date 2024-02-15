using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Car
    {
        // 메서드 + 속성 수 = 멤버 수
        // 속성(필드)
        public string name;
        public string color;
        public int speed;

        // 기능(메서드) 
        // 여기선 static에 저장 X!
        // 차량 속도 조절(올리기)
        public void SpeedUp(int speed = 1)
        {
            this.speed += speed;
        }

        // 차량 속도 조절(내리기)
        public void SpeedDown(int speed = 1)
        {
            this.speed -= speed;
        }

        // 클래스 변수 name, color, speed를 보여준다
        public void Show()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("차량명 : {0}", this.name);
            Console.WriteLine("차량색 : {0}", this.color);
            Console.WriteLine("현재속도 : {0}", this.speed);
            Console.WriteLine("--------------");
        }

    }
}