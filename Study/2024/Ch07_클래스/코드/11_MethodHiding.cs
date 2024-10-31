using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 메소드 숨기기
    교재 p 264 ~ 266

    어떤 메소드가 향후 오버라이딩 될지 안될지를 판단하는 것은 공식이 없다.
    C#은 프로그래머를 위해 메소드 숨기기(Method Hiding)를 사용할 수 있도록 했다.

    메소드 숨기기란, CLR에게 기반 클래스에서 구현된 버전의 메소드를 감추고 부모 클래스에서 구현된 버전만 보여주는 것을 말한다.
    new 한정자를 이용해 사용할 수 있다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _11_MethodHiding
    {

        class Base
        {

            public void MyMethod()
            {

                Console.WriteLine("Base.MyMethod()");
            }
        }

        class Derived : Base
        {

            public new void MyMethod()
            {

                Console.WriteLine("Derived.MyMethod()");
            }
        }

        static void Main11(string[] args)
        {

            Base baseObj = new Base();
            baseObj.MyMethod();         // Base.MyMethod()

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();      // Derived.MyMethod()

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();   // Base.MyMethod()
        }
    }
}
