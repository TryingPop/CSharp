using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 10-2
 * 
 * 기본 예외 처리
 */

namespace Book.Ch10
{
    internal class ex02
    {
        static void Main2(string[] args)
        {
            string[] array = { "가", "나" };
            Console.Write("숫자를 입력해주세요 : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"입력한 위치 값은 '{array[input]}'입니다.");

            if (input < array.Length)
            {
                Console.WriteLine($"입력한 위치의 값은 {array[input]}입니다.");
            }
            else
            {
                Console.WriteLine("인덱스의 범위를 넘었습니다.");
            }
        }
    }
}
