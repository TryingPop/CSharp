using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 피라미드 출력 연습문제
 */

namespace Exam._01
{
    internal class _01_08
    {
        static void Main8(string[] args)
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2*i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
