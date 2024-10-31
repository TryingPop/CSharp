using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 변경불가능한 구조체
    교재 p 282 ~ 285

    객체는 속성과 기능으로 이뤄지는데 속성은 상태(State), 기능은 행위(Behavior)라고도 한다.

    상태의 변화를 허용하는 객체를 변경가능(Mutable) 객체라고 한다.
    허용하지 않는 객체를 변경불가능(Immutable) 객체라고 한다.

    변경불가능 객체는 쓰레드 간에 동기화(Synchronization)를 할 필요가 없기 때문에
    프로그램의 성능 향상이 가능하다.

    구조체는 변경 불가능한 구조체로 선언가능하고, 클래스는 불가능하다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _18_ReadonlyStruct
    {

        readonly struct RGBColor
        {

            public readonly byte R;
            public readonly byte G;
            public readonly byte B;

            public RGBColor(byte r, byte g, byte b)
            {

                R = r;
                G = g;
                B = b;
            }
        }

        static void Main18(string[] args)
        {

            RGBColor Red = new RGBColor(255, 0, 0);
            // visual studio에서 CS0191 컴파일 에러 발생
            // Red.G = 100;
        }
    }
}
