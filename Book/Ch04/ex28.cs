using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.1
 * 내용 : 코드 4-28
 * 
 * 문자열 양 옆의 공백 제거
 */

namespace Book.Ch04
{
    internal class ex28
    {
        static void Main28(string[] args)
        {
            string input = " test        \n";
            // Trim 메서드를 통해 공백 문자 제거
            Console.WriteLine("::" + input.Trim() + "::");
            Console.Read();
        }

    }
}
