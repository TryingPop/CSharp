using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 팩토리얼 연습문제
 */

namespace Exam._02
{
    internal class _02_09
    {
        static void Main9(string[] args)
        {
            Console.WriteLine("3! = {0}", factorial(3));
            Console.WriteLine("4! = {0}", factorial(4));
            Console.WriteLine("5! = {0}", factorial(5));
        }

        public static int factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n*factorial(n - 1);
            }
        }
    }
}
