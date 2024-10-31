using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : this() 생성자
    교재 p 242 ~ 245

    this 생성자를 이용하면 생성자에 중복되는 코드를 많이 제거할 수 있다.
    
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _06_ThisConstructor
    {

        class MyClass
        {

            int a, b, c;

            public MyClass()
            {

                this.a = 1234;
                Console.WriteLine("MyClass()");
            }

            public MyClass(int b) : this()
            {

                this.b = b;
                Console.WriteLine($"MyClass({b})");
            }

            public MyClass(int b, int c) : this(b)
            {

                this.c = c;
                Console.WriteLine($"MyClass({b}, {c})");
            }

            public void PrintFields()
            {

                Console.WriteLine($"a: {a}, b: {b}, c: {c}");
            }
        }

        static void Main(string[] args)
        {

            MyClass a = new MyClass();      // MyClass()
            a.PrintFields();                // a: 1234, b: 0, c: 0
            Console.WriteLine();

            MyClass b = new MyClass(1);     // MyClass()
                                            // MyClass(1)
            b.PrintFields();                // a: 1234, b: 1, c: 0
            Console.WriteLine();

            MyClass c = new MyClass(2, 3);  // MyClass()
                                            // MyClass(2)
                                            // MyClass(2, 3)
            c.PrintFields();                // a: 1234, b: 2, c: 3
        }
    }
}
