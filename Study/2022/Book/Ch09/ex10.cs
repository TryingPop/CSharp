using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 9-10
 * 
 * 인터페이스 생성
 */

namespace Book.Ch09
{
    interface IBasic
    {
        // 메서드 내부 구현 불가능
        // 마찬가지로 속성 내부 구현 불가능
        abstract int TestInstanceMethod();
        abstract int TestProperty { get; set; }
    }

    internal class ex10
    {
        static void Main10(string[] args)
        {

        }
    }
}
