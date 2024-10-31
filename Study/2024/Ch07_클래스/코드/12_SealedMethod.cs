using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 메소드 봉인하기
    교재 p 267 ~ 

    sealed 키워드를 통해 클래스를 상속이 안되도록 하는거처럼 메소드도 오버라이딩이 안되게 봉인할 수 있다.
    오작동 위험이 있거나 잘못 오버라이딩 함으로써 발생할 수 잇는 문제가 예상된다면,
    봉인 메소드를 이용해서 상속을 사전에 막는 것이 낫다.
    그런데 virtual로 선언된 메소드를 오버라이딩한 버전의 메소드만 봉인 메소드로 만들 수 있다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _12_SealedMethod
    {

        class Base
        {

            public virtual void SealMe() { }
        }

        class Derived : Base
        {

            public sealed override void SealMe() { }
        }

        class WantToOverride : Derived
        {

            // visual studio에서 CS0239 컴파일 에러 뜬다
            // public override void SealMe() { }
        }
    }
}
