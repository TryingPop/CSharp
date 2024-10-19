using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-45
 * 
 * 여러 줄로 나누어 적은 증감 연산자
 */

namespace Book.Ch02
{
    internal class ex45
    {
        static void Main45(string[] args)
        {
            int number = 10;
            Console.WriteLine(number);
            number++;
            number++;
            Console.WriteLine(number);
            Console.WriteLine(number);
            number--;
            number--;
            Console.WriteLine(number);
        }
    }
}
