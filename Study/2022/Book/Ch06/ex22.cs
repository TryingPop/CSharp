using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.18
 * 내용 : 코드 6-22
 * 
 * 상수 변경
 */

namespace Book.Ch06
{
    internal class ex22
    {
        static void Main21(string[] args)
        {
            // Math.PI는 상수로 저장되어서 오류뜬다
            // const double Math.PI = 3.14...;
            // Math.PI = 20;

            int r = 10;

            Console.WriteLine("원의 둘레 : {0}", 2 * Math.PI * r);
            Console.WriteLine("원의 넓이 : {0}", Math.PI * (r * r));
        }
    }
}