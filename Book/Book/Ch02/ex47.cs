using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-47
 * 
 * 직접적인 GetType 메서드 활용
 */

namespace Book.Ch02
{
    internal class ex47
    {
        static void Main47(string[] args)
        {
            Console.WriteLine((273).GetType());
            Console.WriteLine((522731033265l).GetType());
            Console.WriteLine((52.273f).GetType());
            Console.WriteLine(('자').GetType());
            Console.WriteLine(("문자열").GetType());
        }
    }
}
