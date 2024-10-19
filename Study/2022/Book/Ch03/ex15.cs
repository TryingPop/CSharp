using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 3-14
 * 
 * 입력 받아 조건 분할
 */

namespace Book.Ch03
{
    internal class ex15
    {
        static void Main15(string[] args)
        {
            Console.Write("문자 입력 : ");
            string input = Console.ReadLine();

            if (input.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요.");
            }
            else
            {
                Console.WriteLine("^^");
            }
        }
    }
}
