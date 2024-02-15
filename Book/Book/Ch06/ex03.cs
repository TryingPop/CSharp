using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-3
 * 
 * 아무것도 반환하지 않는 메서드
 */

namespace Book.Ch06
{
    internal class ex03
    {
        class Test
        {
            public void Print()
            {
                Console.WriteLine("Print() 메서드가 호출되었습니다.");
            }
        }
        static void Main3(string[] args)
        {
            Test Test = new Test();
            Test.Print();
            Test.Print();
            Test.Print();
        }
    }
}
