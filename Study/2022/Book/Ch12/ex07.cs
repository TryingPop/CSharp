using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.28
 * 내용 : 코드 12-7
 * 
 * Linq 결과의 자료형
 */

namespace Book.Ch12
{
    internal class ex07
    {
        static void Main7(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // var해서 갖다대면 타입이 나온다
            IEnumerable<int> output = from item in input
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
