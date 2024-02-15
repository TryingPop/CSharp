using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 6-32
 * 
 * 참조 복사 예
 */

namespace Book.Ch06
{
    internal class ex32
    {
        class Test
        {
            public int value = 10;
        }

        static void Change(Test input)
        {
            input.value = 20;
        }

        static void Main32(string[] args)
        {
            Test test = new Test();
            test.value = 10;
            Change(test);

            Console.WriteLine(test.value);
        }   
    }
}