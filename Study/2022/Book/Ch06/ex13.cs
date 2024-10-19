using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-13
 * 
 * 외부 클래스에서의 접근
 */

namespace Book.Ch06
{
    internal class ex13
    {
        class Test
        {
            public void TestMethod()
            {
                // Program.Main13(new string[] { "" });
            }
        }

        class Program
        {
            // public이 없는 경우 자동 private이므로
            // 실행하면 오류 뜬다
            static void Main13(string[] args)
            {

            }
        }
    }
}
