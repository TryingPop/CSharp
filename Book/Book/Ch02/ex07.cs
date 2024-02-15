using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-7
 * 
 * 음수와 나머지 연산자
 */

namespace Book.Ch02
{
    internal class ex07
    {
        static void Main7(string[] args)
        {
            // 연산자의 부호는 왼쪽 연산자를 따른다
            // 오른쪽 연산자는 관계 없다
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % -3);
        }
    }
}
