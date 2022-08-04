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
    internal class _09_07
    {
        static void Main7(string[] args)
        {
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);
        }

        public static void DrawPyramid(int n)
        {
            for(int i = 1; i <=n; i++)
            {
                for (int j=i; j <n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < 2 * i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

    }
}
