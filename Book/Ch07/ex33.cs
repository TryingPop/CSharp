


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-33
 * 
 * abstract 클래스 오류
 */

namespace Book.Ch07
{
    internal class ex33
    {
        abstract class Parent 
        {
            public void Test() { }
        }

        class Child : Parent
        {
            public void Test() { }
        }

        static void Main33(string[] args)
        {
            // abstract 클래스는 인스턴스로 생성할 수 없다
            // Parent parent = new Parent();
            Child child = new Child();
        }
    }
}
