using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 10-3
 * 
 * 예외 상황 확인
 */

namespace Book.Ch10
{
    internal class ex03
    {
        static void Main3(string[] args)
        {
            Console.Write("입력 : ");
            string input = Console.ReadLine();

            int index = int.Parse(input);
            Console.WriteLine($"입력 숫자 : {index}");
        }
    }
}
