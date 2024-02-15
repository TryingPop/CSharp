using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-22
 * 
 * break 키워드
 */

namespace Book.Ch04
{
    internal class ex22
    {
        static void Main22(string[] args)
        {
            while (true)
            {
                Console.Write("숫자를 입력해주세요(짝수를 입력하면 종료) : ");
                int input = int.Parse(Console.ReadLine());
                
                // 탈출 구문
                if (input % 2 == 0)
                {
                    // 탈출 명령어
                    break;
                }
            }
        }
    }
}
