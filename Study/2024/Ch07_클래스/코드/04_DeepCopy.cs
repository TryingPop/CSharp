using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 객체 복사하기 얕은 복사와 깊은 복사
    교재 p235 ~ 239

    클래스는 참조 형식이기 때문에 복사에 주의해야 한다
    단순 할당 연산자인 =로 클래스를 할당하면

    왼쪽 피연산자와 오른쪽 피연산자가 가리키는 주소는 같다
    그래서 이후 왼쪽 피연산자의 멤버를 수정하면
    오른쪽 피연산자도 왼피연산자와 같은 주소를 가리키기에
    오른쪽 피연산자의 멤버도 같은 값을 갖게 된다

    그래서 =이 아닌 새로운 힙 공간에 객체를 생성해 메모리를 할당한 뒤
    해당 멤버들에 값을 전달 시켜야한다

    Clone 메소드를 이용해 복사하고 싶다면,
    ICloneable 인터페이스를 상속한 뒤
    Clone 메소드를 정의해 깊은 복사가 되게 코드를 작성해야 한다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _04_DeepCopy
    {

        class MyClass
        {

            public int MyField1;
            public int MyField2;

            public MyClass DeepCopy()
            {

                MyClass newCopy = new MyClass();
                newCopy.MyField1 = this.MyField1;
                newCopy.MyField2 = this.MyField2;

                return newCopy;
            }
        }

        static void Main4(string[] args)
        {

            Console.WriteLine("Shallow Copy");

            {

                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");  // 10 30
                Console.WriteLine($"{target.MyField1} {target.MyField2}");  // 10 30
            }

            Console.WriteLine("Deep Copy");

            {

                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");  // 10 20
                Console.WriteLine($"{target.MyField1} {target.MyField2}");  // 10 30
            }
        }
    }
}
