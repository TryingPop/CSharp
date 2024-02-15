using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-27
 * 
 * unsigned 자료형
 */

namespace Book.Ch02
{
    internal class ex27
    {
        static void Main27(string[] args)
        {
            uint unsignedInt = 4147483647;
            ulong unsignedLong = 11223372036854775808;

            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);
        }
    }
}
