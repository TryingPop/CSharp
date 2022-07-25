using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-26
 * 
 * new 메서드를 사용한 하이딩
 */

namespace Book.Ch07
{
    internal class ex26
    {
        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public new string variable = "hiding";
            public new void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main26(string[] args)
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
