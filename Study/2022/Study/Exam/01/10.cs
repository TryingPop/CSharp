using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 피보나치 수열 연습문제
 */

namespace Exam._01
{
    internal class _01_10
    {
        static void Main10(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;

            Console.Write($"{n1}, ");
            Console.Write($"{n2}, ");

            for (int i = 0; i <= 10; i++)
            {
                n3 = n1 + n2;

                Console.Write($"{n3}, ");

                n1 = n2;
                n2 = n3;
            }
        }
    }
}
