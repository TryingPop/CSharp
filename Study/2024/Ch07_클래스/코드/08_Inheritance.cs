using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 상속으로 코드 재활용하기
    교재 p 249 ~ 

    클래스는 다른 클래스로부터 유산을 물려받을 수 있다.
    유산은 필드, 메소드, 그리고 프로퍼티 등과 같은 멤버들이다.

    객체지향 프로그래밍에서는 물려 받는 클래스를 자식 클래스 또는 파생 클래스라고 한다.
    그리고 유산을 물려줄 클래스를 부모 클래스 또는 기반 클래스라고 한다.

    클래스 정의에서 클래스명 뒤에 콜론(:)을 붙여 부모 클래스를 선언하면 된다.
    부모 클래스의 생성자에는 base 키워드를 이용해 접근할 수 있다.

    그리고 sealed 키워드를 이용해 상속이 불가능하도록 선언할 수 있다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _08_Inheritance
    {

        class Base
        {

            protected string Name;
            public Base(string Name)
            {

                this.Name = Name;
                Console.WriteLine($"{this.Name}.Base()");
            }

            ~Base()
            {

                Console.WriteLine($"{this.Name}.~Base()");
            }

            public void BaseMethod()
            {

                Console.WriteLine($"{Name}.BaseMethod()");
            }
        }

        class Derived : Base
        {

            public Derived(string Name) : base(Name)
            {

                Console.WriteLine($"{this.Name}.Derived()");
            }

            ~Derived()
            {

                Console.WriteLine($"{this.Name}.~Derived()");
            }

            public void DerivedMethod()
            {

                Console.WriteLine($"{Name}.DerivedMethod()");
            }
        }

        static void Main8(string[] args)
        {

            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
