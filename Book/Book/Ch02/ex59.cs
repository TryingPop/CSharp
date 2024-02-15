using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-59
 * 
 * 강제 자료형 변환의 데이터 손실 미발생
 */

namespace Book.Ch02
{
    internal class ex59
    {
        static void Main59(string[] args)
        {
            // long 자료형을 int 자료형으로 변환
            long longNumber = 52273;
            int intNumber = (int)longNumber;

            Console.WriteLine("intNumber : {0}",intNumber);
        }
    }
}
