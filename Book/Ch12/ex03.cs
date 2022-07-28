using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.28
 * 내용 : 코드 12-3
 * 
 * Linq 기본 구문
 */

namespace Book.Ch12
{
    internal class ex03
    {
        static void Main3(string[] args)
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 참조연산자
            var output = from item in input
                         where item % 2 == 0
                         orderby item
                         select item;

            /*
            foreach (int item in output)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}
