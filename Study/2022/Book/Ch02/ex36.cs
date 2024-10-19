using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-36
 * 
 * 불 변수 생성
 */

namespace Book.Ch02
{
    internal class ex36
    {
        static void Main36(string[] args)
        {
            bool one = 10 < 0;
            bool other = 20 > 100;

            Console.WriteLine(one);
            Console.WriteLine(other);
            
        }
    }
}
