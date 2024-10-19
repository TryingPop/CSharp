using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.14
 * 내용 : 코드 4-11
 * 
 * do while 반복문 활용
 */

namespace Book.Ch04
{
    internal class ex11
    {
        static void Main11(string[] args)
        {
            string input;
            do
            {
                Console.Write("입력(exit을 입력하면 종료) : ");
                input = Console.ReadLine();
            }
            while (input != "exit");
        }
    }
}
