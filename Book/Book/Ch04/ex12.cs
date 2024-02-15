using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-12
 * 
 * for 반복문으로 덧셈
 */

namespace Book.Ch04
{
    internal class ex12
    {
        static void Main12(string[] args)
        {
            int output = 0;

            for (int i =0; i <= 100; i++)
            {
                output += i;
            }

            Console.WriteLine("output : {0}", output);
        }
    }
}
