using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-42_2
 * 
 * 증감 연산자의 전위 형태
 */

namespace Book.Ch02
{
    internal class ex41_2
    {
        static void Main41_2(string[] args)
        {
            int number = 10;

            Console.WriteLine(number);
            Console.WriteLine(++number);
            Console.WriteLine(--number);
            Console.WriteLine(number);
        }
    }
}
