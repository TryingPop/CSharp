using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-67
 * 
 * 숫자와 문자열 덧셈
 */

namespace Book.Ch02
{
    internal class ex67
    {
        static void Main67(string[] args)
        {
            // 연산에 문자열이 포함되면 문자열 덧셈으로 바뀐다
            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");
        }
    }
}
