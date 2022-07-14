using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-21
 * 
 * 별 피라미드(2)
 */

namespace Book.Ch04
{
    internal class ex21
    {
        static void Main21(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
