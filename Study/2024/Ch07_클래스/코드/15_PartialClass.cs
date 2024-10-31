using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 분할 클래스
    교재 p 274 ~ 276

    분할 클래스(Partial Class)란 여러 번에 나눠서 구현하는 클래스를 말한다.
    클래스의 구현이 길어질 경우 여러 파일에 나눠서 구현할 수 있게 함으로써 소스 코드 관리의 편의를 제공한다.
    partial 키워드를 이용해 작성한다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _15_PartialClass
    {

        partial class MyClass
        {

            public void Method1()
            {

                Console.WriteLine("Method1");
            }

            public void Method2()
            {

                Console.WriteLine("Method2");
            }
        }

        partial class MyClass
        {

            public void Method3()
            {

                Console.WriteLine("Method3");
            }

            public void Method4()
            {

                Console.WriteLine("Method4");
            }
        }

        static void Main15(string[] args)
        {

            MyClass obj = new MyClass();
            obj.Method1();                  // Method1
            obj.Method2();                  // Method2
            obj.Method3();                  // Method3
            obj.Method4();                  // Method4
        }
    }
}
