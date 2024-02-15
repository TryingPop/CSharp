using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-24
 * 
 * continue 키워드
 */

namespace Book.Ch04
{
    internal class ex24
    {
        static void Main24(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine("i : {0}", i);
            }
        }

    }
}
