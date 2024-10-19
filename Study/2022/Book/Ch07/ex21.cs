using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-21
 * 
 * 클래스 변수 상속
 */

namespace Book.Ch07
{
    internal class ex21
    {
        class Parent
        {
            public static int counter = 0;
            
            public void CountParent()
            {
                Parent.counter++;
            }
        }

        class Child : Parent
        {
            public void CountChild()
            {
                Child.counter++;
            }
        }

        static void Main21(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();

            // 참조 변수라 둘이 값이 같을 수 밖에 없다
            parent.CountParent();
            child.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
            
            // 만약 Child 클래스에 
            // public static int counter = 0
            // 를 새로 선언하면 
            // 밑에 값이 각각 1, 2로 서로 다르다
            child.CountChild();
            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
        }
    }
}
