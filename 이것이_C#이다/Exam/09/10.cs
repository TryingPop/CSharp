

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
    internal class _09_10
    {
        static void Main10(string[] args)
        {
            int[] a = { 1, 2, 3 };
            double[] d = { 0.1, 0.2, 0.3 };
            string[] s = { "apple", "banana", "cherry" };

            PrintArray<int>(a);
            PrintArray<double>(d);
            PrintArray<string>(s);
        }

        public static void PrintArray<T>(T[] arr)
        {
            foreach(T item in arr)
            {
                Console.Write("{0, 8}", item);
            }
            Console.WriteLine();
        }
    }
}
