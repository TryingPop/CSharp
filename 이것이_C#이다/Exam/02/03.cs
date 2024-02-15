using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 배열 연습문제
 */

namespace Exam._02
{
    internal class _02_03
    {
        static void Main3(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}, ", arr[i]);
            }
            Console.Write("\n");

            for (int j =0; j < 5; j++)
            {
                int temp = arr[j];
                arr[j] = arr[9 - j];
                arr[9 - j] = temp;
            }

            foreach (int n in arr)
            {
                Console.Write("{0}, ", n);
            }

        }
    }
}
