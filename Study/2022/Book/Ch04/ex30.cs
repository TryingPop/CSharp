using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 4-30
 * 
 * Console.SetCursorPosition 메서드
 */

namespace Book.Ch04
{
    internal class ex30
    {
        static void Main30(string[] args)
        {
            Console.WriteLine("메서드 호출 전");
            // 글자 출력 초기 자리를 x1, y1
            // 그러면 args : a, b 라하면
            // 글자 시작 위치는 x1 + a + 1, y1 + b
            // 의 위치에서 첫글자가 나온다
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출 후");
        }

    }
}
