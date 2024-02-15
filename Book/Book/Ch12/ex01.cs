using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 12-1
 * 
 * 데이터를 선별하는 정형화된 코드
 */

namespace Book.Ch12
{
    internal class ex01
    {
        static void Main1(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();

            foreach (var item in input)
            {
                if (item % 2 == 0)
                {
                    output.Add(item);
                }
            }
            Console.WriteLine(output);
        }
    }
}
