using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 피보나치 연습문제
 */

namespace Exam._02
{
    internal class _02_10
    {
        static void Main10(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{fibo(i)}, ");
            }
        }

        public static int fibo(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return fibo(n-1) + fibo(n - 2);
            }
        }
    }
}
