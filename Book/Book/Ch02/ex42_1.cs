using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-42_1
 * 
 * 증감 연산자의 후위 형태
 */

namespace Book.Ch02
{
    internal class ex41_1
    {
        static void Main41_1(string[] args)
        {
            int number = 10;

            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number--);
            Console.WriteLine(number);
        }
    }
}
