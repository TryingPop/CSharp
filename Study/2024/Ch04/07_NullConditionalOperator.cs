using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : null 조건부 연산자
    교재 p 129 ~ 130

    ? 는 해당 객체가 null인지 판별하고 null이 아닌 경우 접근을 한다
    a?.b인 경우 a가 null이 아니면 b의 멤버에 접근하고
     a?[2]인 경우 a가 null이 아니면 2번째 인덱서에 접근한다
*/

using static System.Console;

namespace Study._2024.Ch04
{
    internal class _07_NullConditionalOperator
    {

        static void Main7(string[] args)
        {

            ArrayList a = null;
            a?.Add("야구");
            a?.Add("축구");

            WriteLine($"Count: {a?.Count}");        // 
            WriteLine($"{a?[0]}");                  // 
            WriteLine($"{a?[1]}");                  // 

            a = new ArrayList();
            a?.Add("야구");
            a?.Add("축구");

            WriteLine($"Count: {a?.Count}");        // 2
            WriteLine($"{a?[0]}");                  // 야구
            WriteLine($"{a?[1]}");                  // 축구
        }
    }
}
