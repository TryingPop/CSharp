using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-23
 * 
 * 변수 하이딩
 */

namespace Book.Ch07
{
    internal class ex23
    {
        class Parent
        {
            public int variable = 273;
        }

        class Child : Parent
        {
            public string variable = "Shadowing";
        }

        static void Main23(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.variable);
        }
    }
}
