using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-4
 * 
 * 배열 생성하고 요소에 접근
 */

namespace Book.Ch04
{
    internal class ex04
    {
        static void Main4(string[] args)
        {
            int[] intArray = { 52, 273, 32, 65, 103 };
            intArray[0] = 0;

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
        }
    }
}
