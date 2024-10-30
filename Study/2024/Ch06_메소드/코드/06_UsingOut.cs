using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 출력 전용 매개변수
    교재 p 200 ~ 203

    대개의 경우 메소드의 결과는 하나면 충분하다
    그러나 두 개 이상의 결과를 요구하는 특별한 메소드도 있다
    이 경우 ref 키워드를 이용해 두 가지 경우를 반환할 수 있다
    그런데 out 키워드를 이용해 반환할 수 있다

    out에는 안전장치가 있어 코드의 안정성이 올라간다.
*/

namespace Study._2024.Ch06_메소드.코드
{
    internal class _06_UsingOut
    {

        static void Divide(int a, int b, out int quotient, out int remainder)
        {

            quotient = a / b;
            remainder = a % b;
        }

        static void Main6(string[] args)
        {

            int a = 20;
            int b = 3;

            Divide(a, b, out int c, out int d);
            // 20 3 6 2
            Console.WriteLine($"a: {a}, b: {b}, a/b: {c}, a%b: {d}");
        }
    }
}
