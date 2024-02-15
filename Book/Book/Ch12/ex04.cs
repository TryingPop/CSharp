using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.28
 * 내용 : 코드 12-4
 * 
 * from in selecct를 사용한 Linq
 */

namespace Book.Ch12
{
    internal class ex04
    {
        static void Main4(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var output = from item in input
                         select item * item;

            
            foreach (int item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
