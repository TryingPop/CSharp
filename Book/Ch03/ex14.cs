using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 3-14
 * 
 * 삼항 연산자를 이용한 자연수 판별
 */

namespace Book.Ch03
{
    internal class ex14
    {
        static void Main14(string[] args)
        {
            Console.Write("숫자 입력 : ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            Console.WriteLine(number > 0 ? "자연수입니다." : "자연수가 아닙니다.");
        }
    }
}
