using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 8
이름 : 배성훈
내용 : 람다식
    교재 p 487 ~ 490

    람다식은 영어로 Lambda Expression이라 하고,
    λ - Expression이라고 표기하기도 한다.

    분명하고 간결한 방법으로 함수를 묘사하기 위해 람다 계산법을 고안했다.
    람다 계산법에서는 모든 것이 함수로 이루어져 있다.

    람다 계산법에서 어떤 값을 변수에 대입하고 싶으면 함수를 변수에 대입하며, 
    이것을 함수의 적용이라 불렀다.
    그리고 이를 컴퓨터에 도입한게 람다식이다.
    C# 뿐만 아니라 C++, 자바, 파이썬에도 람다식을 지원한다.

    람다식은 익명 메소드를 만들기 위해 사용한다.
    람다식으로 만드는 익명 메소드는 무명 함수(Anonymous Function)라는 이름으로 부른다.
    람다식도 매개변수와 반환 값을 갖고 있다.

    C# 컴파일러는 형식 유추(Type Inference)라는 기능을 제공해 변수만 넣어도 형식을 유추해준다.
    그래서 간결하게 작성 가능하다.
*/

namespace Study._2024.Ch14_람다식.코드
{
    internal class _01_SimpleLambda
    {

        delegate int Calculate(int a, int b);

        static void Main1(string[] args)
        {

            Calculate calc = (a, b) => a + b;

            Console.WriteLine($"{3} + {4} : {calc(3, 4)}");
        }
    }
}
