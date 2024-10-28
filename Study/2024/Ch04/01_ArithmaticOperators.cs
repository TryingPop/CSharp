using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : 산술 연산자
    교재 p117 ~ 120

    수치 형식의 데이터를 다루는 연산자
    + : 양쪽 피연산자를 더한다
    - : 왼쪽 피연산자에서 오른쪽 피연산자를 뺀다
    * : 양쪽 피연산자를 곱한다
    / : 왼쪽 연산자를 오른쪽 피 연산자로 나눈 몫을 구한다
    % : 왼쪽 연산자를 오른쪽 피 연산자로 나눈 나머지를 구한다

    연산자에도 우선순위가 있고 곱셈, 나눗셈 나머지 연산자가 덧셈 뺄셈 연산자보다 먼저 처리된다
*/

namespace Study._2024.Ch04
{
    internal class _01_ArithmaticOperators
    {

        static void Main1(string[] args)
        {

            int a = 111 + 222;
            Console.WriteLine($"a : {a}");  // 333

            int b = a - 100;
            Console.WriteLine($"b : {b}");  // 233

            int c = b * 10;
            Console.WriteLine($"c : {c}");  // 2330

            double d = c / 6.3;
            Console.WriteLine($"d : {d}");  // 369.8412698412699

            Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})");  // 3(1)
        }
    }
}
