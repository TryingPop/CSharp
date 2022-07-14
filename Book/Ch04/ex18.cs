using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-18
 * 
 * foreach 반복문과 배열
 */

namespace Book.Ch04
{
    internal class ex18
    {
        static void Main18(string[] args)
        {
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
