using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.29
 * 내용 : 반복자, 반복기(Iterator) - yield return
 */

namespace Private
{
    internal class _2_Iterator
    {
        static void Main2(string[] args)
        {

        }

        static IEnumerable<int> GetNumber()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
    }
}
