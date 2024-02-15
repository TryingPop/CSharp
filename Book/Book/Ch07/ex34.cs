using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-34
 * 
 * abstract 메서드
 */

namespace Book.Ch07
{
    internal class ex34
    {
        abstract class Parent 
        {
            // 메서드에 abstract 를 쓸러면 abstract 클래서여야 한다!
            // 메서드에 abstract로 하면 반드시 override 해야한다
            // 중괄호를 쓰지않고 세미콜론으로 마친다!
            public abstract void Test();
        }

        class Child : Parent
        {
            public override void Test() { }
        }

        static void Main34(string[] args)
        {

        }
    }
}
