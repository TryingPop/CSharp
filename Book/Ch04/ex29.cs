using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 4-29
 * 
 * 배열을 문자열로 변환
 */

namespace Book.Ch04
{
    internal class ex29
    {
        static void Main29(string[] args)
        {
            string[] array = { "감자", "고구마", "토마토", "가지" };
            // args : 구분에 넣을 문자, 배열
            Console.WriteLine(string.Join(", ", array));
        }

    }
}
