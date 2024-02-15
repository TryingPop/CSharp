using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    // 추상클래스 : 추상메서드를 갖는 클래스
    // internal public과 비슷하다
    // 추상클래스 선언 : abstract
    internal abstract class Car
    {
        // 속성
        protected string name;
        protected string color;
        protected int speed;

        // 생성자
        protected Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        // 기능
        public abstract void SpeedUp(int speed);
        public abstract void SpeedDown(int speed);
        
        // 추상클래스라해도 완성된 기능을 가진 메서드는 포함한다
        public virtual void Show()
        {
            Console.WriteLine("======================");
            Console.WriteLine("차량명 : {0}", this.name);
            Console.WriteLine("차량색 : {0}", this.color);
            Console.WriteLine("속도 : {0}", this.speed);
        }
    }
}
