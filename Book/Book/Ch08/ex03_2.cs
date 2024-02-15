using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-3(2)
 * 
 * where 키워드
 */

namespace Book.Ch08
{
    internal class ex03_2
    {
        class Test<T, U>
            where T : IComparable
            where U : IComparable, IDisposable
        {

        }

        static void Main3_2(string[] args)
        {

        }
    }
}
