using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-18
 * 
 * 상속했을 때 기본적인 생성자 호출 순서
 */

namespace Book.Ch07
{
    internal class ex18
    {
        class Parent
        {
            public Parent()
            {
                Console.WriteLine("부모 생성자");
            }
        }

        class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("자식 생성자");
            }
        }

        static void Main18(string[] args)
        {
            // 부모 먼저 생성되고 
            // 자녀가 생성된다
            // 즉, 부모클래스가 자녀 클래스에 포함되어져 있다
            Child child = new Child();
        }
    }
}
