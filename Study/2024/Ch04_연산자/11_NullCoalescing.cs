using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : null 병합 연산자
    교재 p 141 ~ 143

    null 병합 연산자 ?? 는 null 객체 검사를 간결하게 만들어 준다
    a ?? val 이라하면 a가 null인 경우 val을 쓰고 a가 null이 아니면 a를 쓰라는 의미이다
    그래프의 간선 연결에서 edge[i]??= new(); 연산을 썼던거 같다

    연산자도 우선순위가 있다
    1순위 전위 ++, --, ?., ?[] 
    2순위 후위 ++, --
    3순위 산술 연산자 *, /, %
    4순위 산술 연산자 +, -
    5순위 시프트 연산자 <<, >>
    6순위 관계 연산자 is, as, <, >, >=
    7순위 관계 연산자 ==, !=
    8순위 비트 논리 연산자 &
    9순위 비트 논리 연산자 ^
    10순위 비트 논리 연산자 |
    11순위 논리 연산자 &&
    12순위 논리 연산자 ||
    13순위 null 병합 연산자 ??
    14순위 조건 연산자 조건 ? 참 : 거짓
    15순위 할당 연산자 =, *=, /=, ...
*/

namespace Study._2024.Ch04
{
    internal class _11_NullCoalescing
    {

        static void Main11(string[] args)
        {

            int? num = null;
            Console.WriteLine($"{num ?? 0}");   // 0

            num = 99;
            Console.WriteLine($"{num ?? 0}");   // 99

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");   // Default

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");   // Specific
        }
    }
}
