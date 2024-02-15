using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-54
 * 
 * long 자료형을 나타내는 기호 : 대문자
 */

namespace Book.Ch02
{
    internal class ex54
    {
        static void Main54(string[] args)
        {
            // 다음과 같은 표현 지향
            Console.WriteLine(123456 + 65432L);

            Console.WriteLine((123456 + 65432L).GetType());
        }
    }
}
