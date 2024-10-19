using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-6
 * 
 * 범위를 벗어나는 인덱스에 접근
 */

namespace Book.Ch04
{
    internal class ex06
    {
        static void Main6(string[] args)
        {
            int[] intArray = { 52, 273, 32, 65, 103 };

            // 인덱스가 4번까지인데 5번을 입력했으므로 오류문구가 뜬다
            Console.WriteLine(intArray[5]);
        }
    }
}
