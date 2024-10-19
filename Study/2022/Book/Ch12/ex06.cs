using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.28
 * 내용 : 코드 12-6
 * 
 * orderby를 사용한 Linq
 */

namespace Book.Ch12
{
    internal class ex06
    {
        static void Main6(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var output = from item in input
                         where (item > 5) && (item % 2 == 0)
                         orderby item descending // 내림차순
                         select item;

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
