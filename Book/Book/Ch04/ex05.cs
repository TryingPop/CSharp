using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-5
 * 
 * 배열의 Length 속성
 */

namespace Book.Ch04
{
    internal class ex05
    {
        static void Main5(string[] args)
        {
            int[] intArray = { 52, 273, 32, 65, 103 };

            // 배열 만들면 값이 저장되어있다
            // 시작할 때 크기를 측정하기 때문에
            Console.WriteLine(intArray.Length);
        }
    }
}
