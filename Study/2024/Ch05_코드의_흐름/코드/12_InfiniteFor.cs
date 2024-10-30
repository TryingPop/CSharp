using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 29
이름 : 배성훈
내용 : for문을 이용한 무한 반복 코드
    교재 p172 ~ 173

    for 문은 프로그래머에게 몇 번이나 코드를 반복 실행할지를 반드시 입력하도록 요구한다
    그리고 딱 입력한 횟수만큼 코드를 반복 실행한다
    하지만 아무것도 넣지 않으면 무한히 반복하는 코드를 실행하도록 만들 수 있다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _12_InfiniteFor
    {

        static void Main12(string[] args)
        {

            int i = 0;
            for (; ; )
                Console.WriteLine(i++);
        }
    }
}
