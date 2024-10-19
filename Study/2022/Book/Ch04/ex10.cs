using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-10
 * 
 * while 반복문 이용
 */

namespace Book.Ch04
{
    internal class ex10
    {
        static void Main10(string[] args)
        {
            int i = 0;
            int[] intArray = { 52, 273, 32, 65, 103 };

            while (i < intArray.Length)
            {
                // python과 동일
                Console.WriteLine(i + "번째 출력 : " + intArray[i]);

                // 탈출용
                i++;
            }
        }
    }
}
