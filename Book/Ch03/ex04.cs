using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 3-4
 * 
 * 오전과 오후 구분하기
 */

namespace Book.Ch03
{
    internal class ex04
    {
        static void Main4(string[] args)
        {
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전 입니다.");
            }
            if (12 <= DateTime.Now.Hour)
            {
                Console.WriteLine("오후 입니다.");
            }
        }
    }
}
