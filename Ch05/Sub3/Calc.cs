using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub3
{
    internal class Calc
    {
        // 싱글톤 객체
        // 혹은 메서드 전체에 static 붙여넣어도 된다
        private static Calc instance = new Calc();
        public static Calc Instance { get => instance; }
        // 외부에서 해당 클래스를 new 생성 못하게 차단
        private Calc() { }

        public int Plus(int x, int y)
        {
            return x + y;
        }

        public int Minus(int x, int y)
        {
            return x - y;
        }

        public int Multi(int x, int y)
        {
            return x * y;
        }

        public int Div(int x, int y)
        {
            if (x == 0)
            {
                Console.WriteLine("0으로 나눌 수 없습니다");
                return 0;
            }
            else
            {
                return x / y;
            }
            
        }



    }
}