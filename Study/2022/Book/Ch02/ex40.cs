using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-40
 * 
 * 문자열과 관련된 복합 대입 연산자 예제 풀어쓰기
 */

namespace Book.Ch02
{
    internal class ex40
    {
        static void Main40(string[] args)
        {
            string output = "hello";
            
            output = output + "world";
            output = output + "!";
            
            Console.WriteLine(output);
        }
    }
}
