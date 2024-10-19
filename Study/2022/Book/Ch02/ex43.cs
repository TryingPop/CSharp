using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-43
 * 
 * 후위 증감 증산자
 */

namespace Book.Ch02
{
    internal class ex43
    {
        static void Main43(string[] args)
        {
            int number = 10;

            Console.WriteLine(number);
            // number++ 와 같다
            Console.WriteLine(number); number += 1;
            // number-- 와 같다
            Console.WriteLine(number); number -= 1;
            Console.WriteLine(number);
        }
    }
}
