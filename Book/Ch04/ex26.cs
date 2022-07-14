using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-26
 * 
 * 대문자화 소문자화
 */

namespace Book.Ch04
{
    internal class ex26
    {
        static void Main26(string[] args)
        {
            string input = "Potato Tomato";
            // 문자열을 대문자로 변환 메소드
            Console.WriteLine(input.ToUpper());

            // 문자열을 소문자로 변환 메소드
            Console.WriteLine(input.ToLower());
        }

    }
}
