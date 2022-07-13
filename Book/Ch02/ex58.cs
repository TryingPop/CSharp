using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-58
 * 
 * 강제 자료형 변환
 */

namespace Book.Ch02
{
    internal class ex58
    {
        static void Main58(string[] args)
        {
            // long 자료형을 int 자료형으로 변환
            long longNumber = 2147483647L + 2147483647L;
            int intNumber = (int)longNumber;

            Console.WriteLine("intNumber : {0}",intNumber);
        }
    }
}
