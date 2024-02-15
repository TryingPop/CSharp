using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-4
 * 
 * 매개변수와 반환(1)
 */

namespace Book.Ch06
{
    internal class ex04
    {
        class Test
        {
            public int Sum(int min, int max)
            {
                int output = 0;
                for (int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }
        static void Main4(string[] args)
        {
            Test Test = new Test();
            Console.WriteLine(Test.Sum(1, 100));
        }
    }
}
