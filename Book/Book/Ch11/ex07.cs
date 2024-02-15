

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 11-7
 * 
 * 델리게이터 초기화 방법
 */

namespace Book.Ch11
{
    internal class ex07
    {
        public delegate void TestDelegate();

        static void Main7(string[] args)
        {
            TestDelegate delegateA = TestMethod;
            TestDelegate delegateB = delegate () { };
            TestDelegate delegateC = () => { };

            delegateA();
            delegateB();
            delegateC();
        }

        static void TestMethod() 
        {
            
        }
    }
}
