using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-28
 * 
 * partial 클래스
 */

namespace Book.Ch05
{
    internal class ex28
    {
        // 클래스를 분할하는데 사용한다
        partial class Exam
        {
            public int a;
        }
        
        partial class Exam
        {
            public int b;
        }
    }
}
