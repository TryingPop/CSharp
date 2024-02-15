using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-6
 * 
 * 정수와 연산자
 */

namespace Book.Ch02
{
    internal class ex06
    {
        static void Main6(string[] args)
        {
            Console.WriteLine(1 + 2);
            Console.WriteLine(1 - 2);
            Console.WriteLine(1 * 2);
            // int와 int를 나눴으므로 int형태를 갖는다
            // 그래서 소숫점은 버린다
            Console.WriteLine(1 / 2);
            Console.WriteLine(1 % 2);
        }
    }
}
