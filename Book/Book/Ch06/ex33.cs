using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 6-33
 * 
 * 간단한 참조 복사 예
 */

namespace Book.Ch06
{
    internal class ex33
    {
        class Test
        {
            public int value = 10;
        }

        static void Change(Test input)
        {
            input.value = 20;
        }

        static void Main33(string[] args)
        {
            Test testA = new Test();
            Test testB = testA;

            testA.value = 10;
            testB.value = 20;

            Console.WriteLine(testA.value);
        }   
    }
}