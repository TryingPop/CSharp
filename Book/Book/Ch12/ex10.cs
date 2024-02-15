using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.28
 * 내용 : 코드 12-10
 * 
 * 익명 객체를 활용한 Linq
 */

namespace Book.Ch12
{
    internal class ex10
    {
        static void Main10(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var output = from item in input
                         where item % 2 == 0
                         select new // Anonymous 타입 객체
                                    // 단일 개체를 간단하게 캡슐화
                                    // 속성은 컴파일러에서 유추
                         {
                             A = item * 2,
                             B = item * item,
                             C = 100
                         };

            foreach (var item in output)
            {
                Console.WriteLine(item.A);
                Console.WriteLine(item.B);
                Console.WriteLine(item.C);
                Console.WriteLine();
            }
        }
    }
}
