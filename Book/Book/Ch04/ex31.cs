using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/* 날짜 : 2022.07.15
 * 내용 : 코드 4-31
 * 
 * Thread.Sleep 메서드
 */

namespace Book.Ch04
{
    internal class ex31
    {
        static void Main31(string[] args)
        {
            Console.WriteLine("첫 번째 출력");
            // 1000 == 1초
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세 번째 출력");
        }

    }
}
