using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-61
 * 
 * 자동 자료형 변환
 */

namespace Book.Ch02
{
    internal class ex61
    {
        static void Main61(string[] args)
        {
            int intNumber = 2147483647;

            // int 자료형을 long 자료형으로 자동 변환
            long intToLong = intNumber;
            Console.WriteLine("intToLong : {0}", intToLong);

            // int 자료형을 double 자료형으로 자동 변환
            double intToDouble = intNumber;
            Console.WriteLine("intToDouble : {0}", intToDouble);
            
        }
    }
}
