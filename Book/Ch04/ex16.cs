using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-16
 * 
 * 역 for 반복문
 */

namespace Book.Ch04
{
    internal class ex16
    {
        static void Main16(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };

            // 역순으로 출력 
            for (int i = intArray.Length -1; i >=0; i--)
            {
                Console.WriteLine(intArray[i]);
            }

        }
    }
}
