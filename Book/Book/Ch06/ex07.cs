using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-7
 * 
 * 메서드 생성과 사용
 */

namespace Book.Ch06
{
    internal class ex07
    {
        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }
            }
        }

        static void Main7(string[] args)
        {
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));
        }
    }
}
