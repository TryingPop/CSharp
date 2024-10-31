using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 구조체
    교재 p 285 ~ 287

    구조체의 메소드 안에서 구조체 필드 값을 변경 못하게 하려면 
    메소드에 readonly 키워드를 추가하면 된다
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _19_ReadonlyMethod
    {

        struct ACSetting
        {

            public double currentInCelsius; // 현재 온도
            public double target;           // 희망 온도

            public readonly double GetFahrenheit()
            {

                // visual studio 에서 CS1604 컴파일 에러 뜬다
                // target = currentInCelsius * 1.8 + 32;
                return target;
            }
        }
    }
}
