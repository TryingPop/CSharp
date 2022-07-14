using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-25
 * 
 * 4-24를 간단하게 변경
 */

namespace Book.Ch04
{
    internal class ex25
    {
        static void Main25(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("i : {0}", i);
                }
                
            }
        }

    }
}
