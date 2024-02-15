using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-66
 * 
 * 소수점 제거
 */

namespace Book.Ch02
{
    internal class ex66
    {
        static void Main66(string[] args)
        {
            double number = 52.273103;
            // 뒤에 소수점 갯수만큼 반올림해서 보여줌
            Console.WriteLine(number.ToString("0.0"));
            Console.WriteLine(number.ToString("0.00"));
            Console.WriteLine(number.ToString("0.000"));
            Console.WriteLine(number.ToString("0.0000"));
        }
    }
}
