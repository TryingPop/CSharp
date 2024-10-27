using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 열거 형식
    교재 p 80 ~ 82

    여러 상수를 사용해야 하는 경우가 있다
    이 경우 열거형을 이용하면 유용하다

    값을 정의하지 않으면 컴파일러가 알아서 0부터 1씩 추가해 순서대로 서로 다른 값을 채워넣는다
*/

namespace Study._2024.Ch03
{
    internal class _18_Enum
    {

        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main18(string[] args)
        {

            Console.WriteLine((int)DialogResult.YES);       // 0
            Console.WriteLine((int)DialogResult.NO);        // 1
            Console.WriteLine((int)DialogResult.CANCEL);    // 2
            Console.WriteLine((int)DialogResult.CONFIRM);   // 3
            Console.WriteLine((int)DialogResult.OK);        // 4
        }
    }
}
