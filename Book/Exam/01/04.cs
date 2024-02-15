using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 증가, 감소 연산자 연습문제
 */

namespace Exam._01
{
    internal class _01_04
    {
        static void Main4(string[] args)
        {
            int num = 1;
            int result;

            result = num++;
            Console.WriteLine("result : {0}", result);

            result = ++num;
            Console.WriteLine("result : {0}", result);

            result = num--;
            Console.WriteLine("result : {0}", result);

            result = --num;
            Console.WriteLine("result : {0}", result);
        }
    }
}
