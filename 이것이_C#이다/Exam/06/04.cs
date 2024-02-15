using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.29
 * 내용 : 피보나치 연습문제
 */

namespace Exam._06
{
    internal class _06_04
    {
        public delegate bool What(int a);

        static void Main4(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            int n1 = Count(arr, delegate (int x) { return x % 2 != 0; });
            int n2 = Count(arr, delegate (int x) { return x % 2 == 0; });

            Console.WriteLine($"홀수 갯수 : {n1}");
            Console.WriteLine($"짝수 갯수 : {n2}");
        }

        public static int Count(int[] arr, What what)
        {
            int cnt = 0;

            foreach(int n in arr)
            {
                if (what(n) == true)
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
