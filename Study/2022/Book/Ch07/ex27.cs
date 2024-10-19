using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-27
 * 
 * virtual과 override 메서드를 사용한 오버라이딩
 */

namespace Book.Ch07
{
    internal class ex27
    {
        class Parent
        {
            public virtual void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
        }

        class Child : Parent
        {
            public override void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
        }

        static void Main27(string[] args)
        {
            Child child = new Child();
            Console.WriteLine("Child Method");
            child.Method();
            
            // 덮어 씌웠기 때문에 형변환해도
            // 자식 클래스의 메서드로 읽힌다
            Console.WriteLine("Parent Method");
            (child as Parent).Method();
        }
    }
}
