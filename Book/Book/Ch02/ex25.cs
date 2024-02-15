using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-25
 * 
 * 오버플로우
 */

namespace Book.Ch02
{
    internal class ex25
    {
        static void Main25(string[] args)
        {
            int a = 2000000000;
            int b = 1000000000;

            Console.WriteLine(a + b);
        }
    }
}
