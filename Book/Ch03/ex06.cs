using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 3-6
 * 
 * 오전과 오후 구분하기
 */

namespace Book.Ch03
{
    internal class ex06
    {
        static void Main6(string[] args)
        {
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("지금은 오전입니다.");
            }
            else
            {
                Console.WriteLine("지금은 오후입니다.");
            }
        }
    }
}
