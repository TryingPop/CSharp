

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 11-6
 * 
 * 델리게이터 생성 위치
 */

namespace Book.Ch11
{
    // 클래스 외부에서 선언
    public delegate void TestDelegateA();

    internal class ex06
    {
        // 클래스 내부에서 선언
        public delegate void TestDelegateB();

        static void Main6(string[] args)
        {
            TestDelegateA delegateA;
            TestDelegateB delegateB;
        }
    }
}
