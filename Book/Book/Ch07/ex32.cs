

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-32
 * 
 * sealed 메서드 오류
 */

namespace Book.Ch07
{
    internal class ex32
    {
        // sealed 상속 하지 말라는 키워드
        class Parent
        {
            public virtual void Test() { }
        }

        class Child : Parent
        {
            sealed public override void Test() { }
        }

        class GrandChild : Parent 
        {
            // sealed 메서드는 자녀 클래스에서 오버라이딩 불가능하다
            // public override void Test() { }
            // 반면 new는 이용가능하다
            public new void Test() { }
            
        }

        static void Main32(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();

            child.Test();
            parent.Test();
        }
    }
}
