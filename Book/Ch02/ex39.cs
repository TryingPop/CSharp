using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-39
 * 
 * 문자열과 관련된 복합 대입 연산자
 */

namespace Book.Ch02
{
    internal class ex39
    {
        static void Main39(string[] args)
        {
            string output = "hello";

            output += "world";
            output += "!";

            Console.WriteLine(output);
        }
    }
}
