using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 3-7
 * 
 * 중첩 조건문 활용
 */

namespace Book.Ch03
{
    internal class ex07
    {
        static void Main7(string[] args)
        {
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else
            {
                if (DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간입니다.");
                }
                else
                {
                    Console.WriteLine("저녁 먹을 시간입니다.");
                }
            }
        }
    }
}
