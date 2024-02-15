

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.04
 * 내용 : 피보나치 연습문제
 */

namespace Exam._09
{
    internal class _09_09
    {
        static void Main9(string[] args)
        {
            Print(10);
            Print(0.123);
            Print("Sum = ", 123.4);
        }

        public static void Print(double x)
        {
            Console.WriteLine(x);
        }

        public static void Print(string s, double x)
        {
            Console.WriteLine(s+x);
        }

        public static void Print(int x)
        {
            Console.WriteLine(x);
        }
    }
}
