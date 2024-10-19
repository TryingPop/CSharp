using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-53
 * 
 * long 자료형을 나타내는 기호 : 소문자
 */

namespace Book.Ch02
{
    internal class ex53
    {
        static void Main53(string[] args)
        {
            // int 와 long 을 연산하니 long 타입으로 계산된다
            // l은 1과 혼동되기 쉬워서 L로 표기하는게 좋다
            Console.WriteLine(123456 + 65432l);

            Console.WriteLine((123456 + 65432l).GetType());
        }
    }
}
