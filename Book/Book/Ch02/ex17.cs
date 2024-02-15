using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-17
 * 
 * 예외
 */

namespace Book.Ch02
{
    internal class ex17
    {
        static void Main17(string[] args)
        {
            // 예외 처리 되면서 프로그램이 멈춘다
            // 비주얼 스튜디오에서 그냥 런타임하면 오류 발생한다
            // Ctrl + c 키로 강제 종료
            Console.WriteLine("안녕하세요"[100]);

        }
    }
}
