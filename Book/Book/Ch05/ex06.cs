using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-6
 * 
 * List 요소 추가
 */

namespace Book.Ch05
{
    internal class ex06
    {
        static void Main6(string[] args)
        {
            // <>안은 타입형태 
            List<int> list = new List<int>();

            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);

            foreach (int item in list)
            {
                Console.WriteLine("Count : {0}\titem : {1}", list.Count, item);
            }
        }
    }
}
