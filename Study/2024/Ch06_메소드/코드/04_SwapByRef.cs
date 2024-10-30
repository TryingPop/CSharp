using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 참조에 의한 매개변수 전달
    교재 p 195 ~ 197

    두 매개변수의 값을 제대로 교환할 수 있도록 하는 방법은
    매개변수를 참조에 의한 전달(pass by reference)로 넘기면 된다

    값에 의한 전달이 매개변수가 변수나 상수로부터 값을 복사하는 것과 달리,
    참조에 의한 전달은 매개변수가 메소드에 넘겨진 원본 변수를 직접 참조한다
    그래서 메소드 안에서 매개변수를 수정하면 이 매개변수가 참조하고 있는 원본 변수에 수정이 이뤄진다.
*/

namespace Study._2024.Ch06_메소드.코드
{
    internal class _04_SwapByRef
    {

        static void Swap(ref int a, ref int b)
        {

            int temp = b;
            b = a; 
            a = temp;
        }

        static void Main4(string[] args)
        {

            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}"); // x:3, y:4

            Swap(ref x, ref y);

            Console.WriteLine($"x:{x}, y:{y}"); // x:4, y:3
        }
    }
}
