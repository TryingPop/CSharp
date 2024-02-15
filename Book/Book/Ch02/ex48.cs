using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-48
 * 
 * var 키워드
 */

namespace Book.Ch02
{
    internal class ex48
    {
        static void Main48(string[] args)
        {
            // 알아서 타입을 찾는다
            // 메모리 할당도 타입에 맞춰서 한다
            var number = 100;

            Console.WriteLine("number : " + number.GetType());
        }
    }
}
