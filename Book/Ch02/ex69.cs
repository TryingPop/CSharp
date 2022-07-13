using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-69
 * 
 * 문자열을 불로 변환
 */

namespace Book.Ch02
{
    internal class ex69
    {
        static void Main69(string[] args)
        {
            // 변환시 true false 대소문자는 상관없다
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("False"));
            
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("false"));

            Console.WriteLine(bool.Parse("tRue"));

            // python처럼 true false 변환이 안된다
            Console.WriteLine(bool.Parse("0"));
        }
    }
}
