using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-22
 * 
 * 섀도잉
 */

namespace Book.Ch07
{
    internal class ex22
    {
        public static int number = 10;

        static void Main22(string[] args)
        {
            int number = 20;
            // c# 에서는 자신과 가장 가까운 변수를 사용한다
            // Console.WriteLine(number);와 가장 가까운 number 변수는 지역변수 number이고 값은 20
            Console.WriteLine(number);
        }
    }
}
