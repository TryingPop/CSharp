using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-14
 * 
 * 내부 클래스에서의 접근
 */

namespace Book.Ch06
{
    internal class ex14
    {
        class Test
        {
            public void TestMethod()
            {
                ex14.Main14(new string[] { "" });
            }
        }

        public void TestMethod()
        {
            ex14.Main14(new string[] { "" });
        }

        static void Main14(string[] args)
        {

        }
    }
}
