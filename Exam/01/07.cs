using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 조건문, 반복문 연습문제
 */

namespace Exam._01
{
    internal class _01_07
    {
        static void Main7(string[] args)
        {
            int total = 0;

            for (int k =1; k <= 10; k++)
            {
                if (k % 2 == 0 || k % 3 == 0)
                {
                    total += k;
                }
            }
            Console.WriteLine("1~10까지 2 또는 3배수의 정수의 합 : {0}", total);
        }
    }
}
