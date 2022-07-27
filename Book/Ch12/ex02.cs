using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 12-2
 * 
 * Linq를 사용해 간단하게 작성
 */

namespace Book.Ch12
{
    internal class ex02
    {
        static void Main2(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var output = from item in input
                         where item % 2 == 0
                         select item;

            // List<int> change = (output as List<int>);
            // foreach 같은게 iterator(반복자)의 예시

        }
    }
}
