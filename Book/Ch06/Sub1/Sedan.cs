using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    // Car에서 미구현된 메서드를 구현해야 오류표시 사라진다
    internal class Sedan : Car
    {
        private int cc;

        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        public override void SpeedDown(int speed)
        {
            base.speed -= speed;
            Console.WriteLine("Sedan SpeedDown...");
        }

        public override void SpeedUp(int speed)
        {
            base.speed += speed;
            Console.WriteLine("Sedan SpeedUp...");
        }
        
        // override 자리에 new가 초기값으로 있다
        public override void Show()
        {
            base.Show();
            Console.WriteLine("배기량 : {0}", this.cc);
            Console.WriteLine("======================");
        }
    }
}
