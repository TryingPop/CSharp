using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch05.Sub4;


namespace Ch05.Sub4
{
    internal class Sedan : Car
    {
        // 배기량
        private int cc;

        // 자식클래스에서 부모크 ㄹ래스의 속성을 초기화하기 위해 부모클래스의 생성자 호출
        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        // this.Name이 아닌
        // 그냥 name으로 하면
        // private라 참조 불가능
        // 부모 클래스에 protected로 바꿈
        // 그런데 앞에 Getter 을 했기 때문에
        // Getter로 불러온다
        // Override
        public override void Show()
        {
            Console.WriteLine("--------------");
            // base.?? 부모클래스의 인스턴스 변수 접근
            Console.WriteLine("차량명 : {0}", base.Name);
            Console.WriteLine("차량색 : {0}", base.Color);
            Console.WriteLine("현재속도 : {0}", base.Speed);
            Console.WriteLine("배기량 : {0}", this.cc);
            Console.WriteLine("--------------");
        }

    }
}