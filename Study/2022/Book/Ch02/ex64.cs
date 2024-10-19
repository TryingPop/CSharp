using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-64
 * 
 * 숫자로 변환할 수 없는 문자열을 변환하는 경우
 */

namespace Book.Ch02
{
    internal class ex64
    {
        static void Main64(string[] args)
        {
            // 예외가 발생
            Console.WriteLine(int.Parse("52.273"));
            Console.WriteLine(int.Parse("abc"));
        }
    }
}
