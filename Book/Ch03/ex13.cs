using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 3-13
 * 
 * 삼항 연산자
 */

namespace Book.Ch03
{
    internal class ex13
    {
        static void Main13(string[] args)
        {
            // 참과 거짓 위치에 불 자료형 사용
            Console.Write("숫자 입력 : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine((number % 2 == 0) ? true : false);

            // 참과 거짓 위치에 문자열 자료형 사용
            Console.WriteLine((number % 2 == 0) ? "짝수" : "홀수");
        }
    }
}

// 삼항 연산자를 쓰려면 대입을 해줘야한다.
// 혹은 호출
