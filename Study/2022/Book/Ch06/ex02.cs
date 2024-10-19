using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-2
 * 
 * 두 개의 매개변수를 갖는 메서드
 */

namespace Book.Ch06
{
    internal class ex02
    {
        class Test
        {
            public int Multi(int x, int y)
            {
                return x * y;
            }
        }
        static void Main2(string[] args)
        {
            Test Test = new Test();
            Console.WriteLine(Test.Multi(52, 273));
            Console.WriteLine(Test.Multi(103, 32));
        }
    }
}
