using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 9-5
 * 
 * 인터페이스 인스턴스화(오류 발생)
 */

namespace Book.Ch09
{
    internal class ex05
    {
        static void Main5(string[] args)
        {
            // 인터페이스는 실체가 없는 규칙이므로 인스턴스화할 수 없다
            // IComparable comparable = new IComparable();
        }
    }
}
