using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-14
 * 
 * 한글 전부 출력
 */

namespace Book.Ch04
{
    internal class ex14
    {
        static void Main14(string[] args)
        {
            for (int i = '가'; i <= '힣'; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
