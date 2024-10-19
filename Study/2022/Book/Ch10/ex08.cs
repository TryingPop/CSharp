using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 10-8
 * 
 * 예외 상황 확인
 */

namespace Book.Ch10
{
    internal class ex08
    {
        static void Main8(string[] args)
        {
            Console.Write("입력 : ");
            string input = Console.ReadLine();
            int[] array = { 52, 273, 32, 103 };

            int index = int.Parse(input);
            Console.WriteLine($"입력 숫자 : {index}");
            Console.WriteLine($"배열 요소 : {array[index]}");
        }
    }
}
