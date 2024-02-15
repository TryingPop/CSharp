using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-60
 * 
 * 숫자 손상
 */

namespace Book.Ch02
{
    internal class ex60
    {
        static void Main60(string[] args)
        {
            // long 자료형을 int 자료형으로 변환
            long longNumber = 2147483647L + 2147483647L;
            int intNumber = (int)longNumber;

            Console.WriteLine("intNumber : {0}",intNumber);

            // double 자료형을 int 자료형으로 변환
            double doubleNumber = 52.27310332;
            int doubleToInt = (int)doubleNumber;
            
            Console.WriteLine("doubleToInt : {0}",doubleToInt);
        }
    }
}
