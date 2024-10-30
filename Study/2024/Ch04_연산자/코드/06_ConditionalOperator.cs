using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : 조건 연산자
    교재 p 128 ~ 129

    조건식 ? 참일 때의 값 : 거짓일 때의 값
    형식으로 사용한다
*/

namespace Study._2024.Ch04
{
    internal class _06_ConditionalOperator
    {

        static void Main6(string[] args)
        {

            string result = (10 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);      // 짝수
        }
    }
}
