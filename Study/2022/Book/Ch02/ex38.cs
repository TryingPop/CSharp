using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-38
 * 
 * 숫자와 관련된 복합 대입 연산자 다른 방식
 */

namespace Book.Ch02
{
    internal class ex38
    {
        static void Main38(string[] args)
        {
            int output = 0;
            output = output + 52;
            output = output + 273;
            output = output + 103;

            Console.WriteLine(output);
        }
    }
}
