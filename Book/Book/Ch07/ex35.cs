using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-35
 * 
 * abstract 메서드와 관련된 오류 해결
 */

namespace Book.Ch07
{
    internal class ex35
    {
        abstract class Parent 
        {
            public abstract void Test();
        }

        class Child : Parent
        {
            public override void Test() { }
        }

        static void Main35(string[] args)
        {

        }
    }
}
