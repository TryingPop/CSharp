using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-22
 * 
 * 논리 부정 연산자
 */

namespace Book.Ch02
{
    internal class ex22
    {
        static void Main22(string[] args)
        {
            // 현재 시간을 가져오는 모듈(?)
            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);
        }
    }
}
