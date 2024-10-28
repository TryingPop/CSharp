using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 열거 형식
    교재 p 84 ~ 85

    프로그래머가 직접 enum 에 값을 채워 넣는 예제다
    입력된 값을 기준으로 1씩 증가 시킨다
*/

namespace Study._2024.Ch03
{
    internal class _20_Enum3
    {

        enum DialogResult { YES = 10, NO, CANCEL, CONFIRM = 10, OK }

        static void Main20(string[] args)
        {

            Console.WriteLine((int)DialogResult.YES);           // 10
            Console.WriteLine((int)DialogResult.NO);            // 11
            Console.WriteLine((int)DialogResult.CANCEL);        // 12
            Console.WriteLine((int)DialogResult.CONFIRM);       // 10
            Console.WriteLine((int)DialogResult.OK);            // 11
        }
    }
}
