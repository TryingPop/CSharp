using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-15
 * 
 * 시간을 사용한 반복문 이탈
 */

namespace Book.Ch04
{
    internal class ex15
    {
        static void Main15(string[] args)
        {
            long start = DateTime.Now.Ticks;
            long count = 0;

            // 10000000Ticks == 1초
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }

            Console.WriteLine("{0} 만큼 반복했습니다.", count);
        }
    }
}
