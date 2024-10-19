using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-5
 * 
 * 매개변수와 반환(2)
 */

namespace Book.Ch06
{
    internal class ex05
    {
        class Test
        {
            public int Multiply(int min, int max)
            {
                int output = 1;
                for (int i = min; i <= max; i++)
                {
                    output *= i;
                }
                return output;
            }
        }

        static void Main5(string[] args)
        {
            Test Test = new Test();
            Console.WriteLine(Test.Multiply(1, 10));
        }
    }
}
