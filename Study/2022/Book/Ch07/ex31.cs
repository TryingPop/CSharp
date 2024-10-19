
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-31
 * 
 * sealed 클래스 오류
 */

namespace Book.Ch07
{
    internal class ex31
    {
        // sealed 상속 하지 말라는 키워드
        sealed class Parent
        {
            public void Test() { }
        }

        class Child // : Parent
        {
            public void Test() { }
        }

        static void Main31(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();

            parent.Test();
            child.Test();
        }
    }
}
