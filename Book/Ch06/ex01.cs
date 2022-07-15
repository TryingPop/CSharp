using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-1
 * 
 * 인스턴스 메서드 생성과 사용
 */

namespace Book.Ch06
{
    internal class ex01
    {
        class Test
        {
            public int Power(int x)
            {
                return x * x;
            }
        }
        static void Main1(string[] args)
        {
            Test Test = new Test();
            Console.WriteLine(Test.Power(10));
            Console.WriteLine(Test.Power(20));
        }
    }
}
