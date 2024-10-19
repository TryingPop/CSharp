using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-24
 * 
 * 숨겨진 멤버를 찾는 방법
 */

namespace Book.Ch07
{
    internal class ex24
    {
        class Parent
        {
            public int variable = 273;
        }

        class Child : Parent
        {
            public string variable = "Shadowing";
        }

        static void Main24(string[] args)
        {
            Child child = new Child();
            // 형변환을 통해 찾을 수 있다
            Console.WriteLine((child as Parent).variable);
        }
    }
}
