using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-62
 * 
 * 문자열을 숫자로 변환
 */

namespace Book.Ch02
{
    internal class ex62
    {
        static void Main62(string[] args)
        {
            // string 자료형을 int 자료형으로 변환
            string numberString = "52273";

            // 문자열은 Casting을 쓰면 오류난다
            // int intNumber = (int)numberString;

            int intNumber = int.Parse(numberString);
            Console.WriteLine("intNumber : {0}", intNumber);
            Console.WriteLine("intNumber : {0}", intNumber.GetType());

        }
    }
}
