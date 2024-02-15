using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-44
 * 
 * 증감 연산자 이해도 확인
 */

namespace Book.Ch02
{
    internal class ex44
    {
        static void Main44(string[] args)
        {
            int number = 10;

            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);
        }
    }
}
