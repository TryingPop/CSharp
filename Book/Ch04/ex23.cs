using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-23
 * 
 * goto 키워드
 */

namespace Book.Ch04
{
    internal class ex23
    {
        static void Main23(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("외부 반복문");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("내부 반복문");
                    
                    goto doNotUse;
                }
            }
        doNotUse:
            Console.WriteLine("goto 키워드");
        }

    }
}
