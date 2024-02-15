using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-3(1)
 * 
 * where 키워드
 */

namespace Book.Ch08
{
    internal class ex03_1
    {
        class Test<T, U>
            where T : class
            where U : struct
        {

        }

        static void Main3_1(string[] args)
        {

        }
    }
}
