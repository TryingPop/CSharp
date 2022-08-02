
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.02
 * 내용 : 피보나치 연습문제
 */

namespace Exam._07
{
    internal class _07_10
    {
        static void Main10(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine("값 복사");
            Swap(x, y);
            Console.WriteLine($"x : {x}, y : {y}");

            Console.WriteLine("참조 복사");
            Swap(ref x, ref y);
            Console.WriteLine($"x : {x}, y : {y}");
        }

        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}
