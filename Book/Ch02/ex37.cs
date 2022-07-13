using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-37
 * 
 * 숫자와 관련된 복합 대입 연산자
 */

namespace Book.Ch02
{
    internal class ex37
    {
        static void Main37(string[] args)
        {
            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);
        }
    }
}
