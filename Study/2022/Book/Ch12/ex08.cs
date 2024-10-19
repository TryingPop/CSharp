using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.28
 * 내용 : 코드 12-8
 * 
 * ToArray() 메서드
 */

namespace Book.Ch12
{
    internal class ex08
    {
        static void Main8(string[] args)
        {
        }

        public int[] SelectEven(int[] input)
        {
            // var해서 갖다대면 타입이 나온다
            IEnumerable<int> output = from item in input
                                      where (item > 5) && (item % 2 == 0)
                                      orderby item descending // 내림차순
                                      select item;
            return output.ToArray();
        }
    }
}
