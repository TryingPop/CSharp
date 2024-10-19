using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 6-34
 * 
 * 재귀 메서드
 */

namespace Book.Ch06
{
    internal class ex34
    {
        static void Main34(string[] args)
        {
            // 자기자신을 호출한다
            // 계속 호출해서 종료되지 않는다
            // 그래서 종료 조건이 필요하다
            Main34(new string[0]);
        }   
    }
}