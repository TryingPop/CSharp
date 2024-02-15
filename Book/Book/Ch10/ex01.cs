using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 10-1
 * 
 * 예외 상황 확인
 */

namespace Book.Ch10
{
    internal class ex01
    {
        static void Main1(string[] args)
        {
            string[] array = { "가", "나" };
            Console.Write("숫자를 입력해주세요 : ");
            // 문자를 입력하는 경우 오류 발생
            int input = int.Parse(Console.ReadLine());
            // 숫자가 음수이거나 2보다 크거나 같은 경우 오류 발생
            Console.WriteLine($"입력한 위치 값은 '{array[input]}'입니다.");
        }
    }
}
