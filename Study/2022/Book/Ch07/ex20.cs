using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-20
 * 
 * base 키워드를 사용한 생성자 지정(2)
 */

namespace Book.Ch07
{
    internal class ex20
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("Parent()");
            }
            // Overload
            public Parent(int param)
            {
                Console.WriteLine("Parent(int param)");
            }
            // Overload
            public Parent(string param)
            {
                Console.WriteLine("Parent(string param)");
            }
        }

        class Child : Parent
        {
            public Child() : base(10) // Parent(int param)을 호출
            {
                Console.WriteLine("Child() : Parent(10)");
            }

            public Child(string input) : base(input) // Parent(string param)을 호출
            {
                Console.WriteLine("Child(string input) : Parent(input)");
            }
        }

        static void Main20(string[] args)
        {
            Child child1 = new Child();
            Child child2 = new Child("string");
        }
    }
}
