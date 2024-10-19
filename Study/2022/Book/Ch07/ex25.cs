using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-25
 * 
 * 메서드 하이딩
 */

namespace Book.Ch07
{
    internal class ex25
    {
        class Parent
        {
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            // 초기값으로 new가 잡혀있다
            // new는 부모 클래스에 virtual, abstract등을 요구하지 않는다
            public void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main25(string[] args)
        {
            Child child = new Child();
            Console.WriteLine("Child Method");
            child.Method();
            // 형변환하면 부모 클래스의 메서드도 접근 가능!
            Console.WriteLine("Parent Method");
            (child as Parent).Method();
        }
    }
}
