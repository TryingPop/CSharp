using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-57
 * 
 * 강제 자료형 변환
 */

namespace Book.Ch02
{
    internal class ex57
    {
        static void Main57(string[] args)
        {
            // Casting
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;

            // 원하는 형태로 정상적인 변환 완료
            Console.WriteLine("a : {0}", a.GetType());
            Console.WriteLine("b : {0}", b.GetType());
            Console.WriteLine("c : {0}", c.GetType());
        }
    }
}
