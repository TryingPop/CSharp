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
    internal class _02_01
    {
        static void Main1(string[] args)
        {
            char[] str = { 'I', ' ', 'L', 'O', 'V', 'E', ' ', 'Y', 'O', 'U' };
            int row, col;

            for (row = 1; row < 10; row++) 
            {
                for (col = 0; col <= row; col++)
                {
                    Console.Write(str[col]);
                }
                Console.Write("\n");
            }
        }
    }
}
