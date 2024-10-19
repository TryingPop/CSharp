using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-20
 * 
 * 별 피라미드(1)
 */

namespace Book.Ch04
{
    internal class ex20
    {
        static void Main20(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
