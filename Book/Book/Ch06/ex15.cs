using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-15
 * 
 * public 접근 제한자를 붙인 Main() 메서드
 */

namespace Book.Ch06
{
    internal class ex15
    {
        public void TestMethod()
        {
            ex15.Main15(new string[] { "" });
        }

        public static void Main15(string[] args)
        {

        }
    }
}
