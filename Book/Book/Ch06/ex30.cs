using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 6-30
 * 
 * 값 복사 예
 */

namespace Book.Ch06
{

    internal class ex30
    {
        static void Change(int input)
        {
            input = 20;
        }
        static void Main30(string[] args)
        {
            int a = 10;
            ex30.Change(a);
            Console.WriteLine(a);
        }
    }
}