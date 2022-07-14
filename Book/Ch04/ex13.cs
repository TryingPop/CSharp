using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-13
 * 
 * for 반복문으로 곱셈
 */

namespace Book.Ch04
{
    internal class ex13
    {
        static void Main13(string[] args)
        {
            int output = 1;

            for (int i = 1; i <= 20; i++)
            {
                output *= i;
            }

            Console.WriteLine("output : {0}", output);
        }
    }
}
