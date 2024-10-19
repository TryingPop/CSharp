using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-8
 * 
 * 리스트 요소 제거
 */

namespace Book.Ch05
{
    internal class ex08
    {
        static void Main8(string[] args)
        {
            List<int> list = new List<int>() { 52, 273, 32, 64 };

            list.Remove(52);

            foreach (int item in list)
            {
                Console.WriteLine("Count : {0}\titem : {1}", list.Count, item);
            }
        }
    }
}
