using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : 증감연산자
    교재 p 120 ~ 122

    ++ : 피연산자의 값을 1 증가시킨다
    -- : 피연산자의 값을 1 감소시킨다
    증감연산자는 할당 연산자 도움없이 해당 변수의 값을 직접 바꾼다
    연산자 위치에 따라 전위, 후위로 나뉜다
    전위는 해당 코드 바로 앞에 연산된다고 생각하면 되고
    후위는 해당 코드 바로 뒤에 연산된다고 생각하면 된다
*/

namespace Study._2024.Ch04
{
    internal class _02_IncDecOperator
    {

        static void Main2(string[] args)
        {

            int a = 10;
            Console.WriteLine(a++);     // 10
            Console.WriteLine(++a);     // 12

            Console.WriteLine(a--);     // 12
            Console.WriteLine(--a);     // 10
        }
    }
}
