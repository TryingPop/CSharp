using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-7
 * 
 * List 인스턴스 생성과 동시에 요소 추가
 */

namespace Book.Ch05
{
    internal class ex07
    {
        static void Main7(string[] args)
        {
            // <>안은 타입형태 
            List<int> list = new List<int>() { 52, 273, 32, 64};

            foreach (int item in list)
            {
                Console.WriteLine("Count : {0}\titem : {1}", list.Count, item);
            } 
        }
    }
}
