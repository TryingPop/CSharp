using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.03
 * 내용 : 피보나치 연습문제
 */

namespace Exam._08
{
    internal class _08_10
    {
        static void Main10(string[] args)
        {
            for (int y = 1; y<= 9; y++)
            {
                for (int x = 2; x <= 9; x++)
                {
                    Console.Write("{0}x{1}={2, 2}\t", x, y, x*y);
                }
                Console.WriteLine();
            }

        }
    }
}
