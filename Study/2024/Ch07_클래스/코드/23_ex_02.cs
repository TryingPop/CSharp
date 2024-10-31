using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 연습문제 2
    교재 p 292

    다음 코드에서 오류를 찾고, 오류의 원인을 설명하세요.
    
        class A { }
        class B : A { }
        class C
        {
        
            public static void Main()
            {

                A a = new A();
                B b = new B();
                A c = new B();
                B d = new A();            
            }
        }


    d에서 컴파일 에러가 발생할 것이다.
    자식 클래스가 부모 클래스에 기반해 만들어지기 때문에
    자식 클래스는 부모클래스로 형 변환이 가능하나
    부모클래스에서 자식 클래스로 형 변환은 불가능하다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _23_ex_02
    {

        class A { }
        class B : A { }
        class C
        {

            public static void Main23()
            {

                A a = new A();
                B b = new B();
                A c = new B();
                // visual studio 에서 CS0266 컴파일 에러 발생
                // B d = new A();
            }
        }
    }
}
