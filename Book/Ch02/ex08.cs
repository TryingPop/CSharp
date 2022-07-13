using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-8
 * 
 * 실수
 */

namespace Book.Ch02
{
    internal class ex08
    {
        static void Main8(string[] args)
        {
            Console.WriteLine(52.273);
            // 길게 적어도 double의 길이만큼만 나온다
            // 나머지는 반올림되어 짤린다
            Console.WriteLine(22.3111245123123135434563452344);
        }
    }
}
