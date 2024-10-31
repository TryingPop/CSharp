using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 추상 클래스
    교재 p 315 ~ 318

    추상 클래스는 구현을 가질 수 있다.
    하지만 클래스와 달리 인스턴트는 가질 수 없다.

    abstract 한정자와 class 한정자를 이용해 구현 가능하다.

    추상 클래스에 인스턴트를 만들 수 없지만 추상 메소드(Abstract Method)를 가질 수 있다.
    추상 메소드는 추상 클래스가 인터페이스의 역할도 할 수 있게 하는 장치이다.

    구현을 갖지는 못하지만 파생 클래스에서 반드시 구현하도록 강제한다.
    추상메소드의 접근성은 한정자를 명시하지 않으면 private지만 
    추상 메소드의 private 선언은 컴파일러는 이를 허용하지 않는다.
    
    추상 클래스는 추상클래스를 상속할 수 있으며 부모 추상클래스의 추상메소드를 구현하지 않아도 된다.
*/

namespace Study._2024.Ch08_인터페이스와_추상_클래스.코드
{
    internal class _05_AbstractClass
    {

        abstract class AbstractBase
        {

            protected void PrivateMethodA()
            {

                Console.WriteLine("AbstractBase.PrivateMethodA()");
            }

            public void PublicMethodA()
            {

                Console.WriteLine("AbstractBase.PublicMethodA()");
            }

            public abstract void AbstractMethodA();
        }

        class Derived: AbstractBase
        {

            public override void AbstractMethodA()
            {

                Console.WriteLine("Derived.AbstractMethodA()");
                PrivateMethodA();
            }
        }

        static void Main(string[] args)
        {

            AbstractBase obj = new Derived();
            obj.AbstractMethodA();  // Derived.AbstractMethodA()
                                    // AbstractBase.PrivateMethodA()
            obj.PublicMethodA();    // AbstractBase.PublicMethod()
        }
    }
}
