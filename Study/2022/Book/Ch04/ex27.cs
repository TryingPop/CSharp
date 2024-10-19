using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 4-27
 * 
 * 문자열 자르기
 */

namespace Book.Ch04
{
    internal class ex27
    {
        static void Main27(string[] args)
        {
            string input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' });

            foreach (string item in inputs)
            {
                Console.WriteLine(item);
            }
        }

    }
}
