using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 읽기 전용 필드
    교재 p 269 ~ 270

    컴파일러는 상수에 지정된 값을 실행파일 안에 기록해둔다.
    다시 말해 상수는 프로그램이 실행되기 전부터 이미 정해져 있다.
    읽기 전용 필드는 상수와 변수 그 중간 어딘가에 있다.<br/>

    읽기 전용 필드는 읽기만 가능한 필드를 의미한다.
    클래스나 구조체의 멤버로만 존재할 수 있으며 생성자 안에서 한 번 값을 지정하면,
    그 후로는 값을 변경할 수 없는 것이 특징이다.
    readonly를 이용해 선언할 수 있다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _13_ReadonlyFields
    {

        class Configuration
        {

            private readonly int min;
            private readonly int max;

            public Configuration(int v1, int v2)
            {

                min = v1;
                max = v2;
            }

            public void ChangeMax(int newMax)
            {

                // visual studio에서 CS0191 컴파일 에러 일으킨다.
                // max = newMax;
            }
        }
    }
}
