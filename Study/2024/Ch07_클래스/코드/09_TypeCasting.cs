using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 기반 클래스와 파생 크래스 사이의 형식 변환, 그리고 is와 as
    교재 p 255 ~ 260

    기반 클래스와 파생 클래스 사이에는 족보를 오르내리는 형식 변환이 가능하다.
    파생 클래스의 인스턴스는 기반 클래스의 인스턴스로서도 사용할 수 있다.

    형식 변환을 위해서 is와 as키워드를 사용한다
    is는 객체가 해당 형식에 해당하는지 검사하여 그 결과를 bool로 반환한다.
    as는 형식 변환 연산자와 같은 역할을 한다 형식 변환 연산자가 변환에 실패하는 경우 예외를 던지는데,
    as 연산자는 객체 참조를 null로 만든다.

    소괄호를 이용한 형변환보다는 as 연산자를 사용하는 쪽을 권장한다
    실패하더라도 코드의 실행이 점프하는 경우가 없으므로 코드를 관리하기가 더 수월하기 때문이다
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _09_TypeCasting
    {

        class Mammal
        {

            public void Nurse()
            {

                Console.WriteLine("Nurse()");
            }
        }

        class Dog : Mammal
        {

            public void Bark()
            {

                Console.WriteLine("Bark()");
            }
        }

        class Cat : Mammal
        {

            public void Meow()
            {

                Console.WriteLine("Meow()");
            }
        }

        static void Main9(string[] args)
        {

            Mammal mammal1 = new Dog();
            Dog dog;

            // Bark()
            if (mammal1 is Dog)
            {

                dog = (Dog)mammal1;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();

            Cat cat = mammal2 as Cat;

            // Meow()
            if (cat != null)
            {

                cat.Meow();
            }

            Cat cat2 = mammal1 as Cat;

            // cat2 is not a Cat
            if (cat2 != null)
                cat2.Meow();
            else
                Console.WriteLine("cat2 is not a Cat");
        }
    }
}
