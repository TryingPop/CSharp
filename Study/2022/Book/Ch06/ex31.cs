using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 6-31
 * 
 * 간단한 값 복사 예
 */

namespace Book.Ch06
{

    internal class ex31
    {
        static void Main31(string[] args)
        {
            int a = 10;
            int input = a;
            input = 20;
            Console.WriteLine(a);
        }   
    }
}