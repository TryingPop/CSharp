using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 메소드 오버로딩
    교재 p 203 ~ 206

    오버로딩(Overloading)이란 과적하다라는 뜻을 갖고 있다
    과적이란 탑재량을 넘겨 싣는 것을 말한다
    메소드의 오버로딩은 하나의 메소드 이름에 여러 개의 구현을 올리는 것을 말한다

    매개변수만 분석해 어떤 함수가 호출될지를 찾아준다
    반환형식은 상관없다
*/

namespace Study._2024.Ch06_메소드.코드
{
    internal class _07_Overloading
    {

        static int Plus(int a, int b)
        {

            Console.WriteLine($"Calling int Plus(int, int)...");
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {

            Console.WriteLine("Calling int Plus(int, int, int)...");
            return a + b + c;
        }

        static double Plus(double a, double b)
        {

            Console.WriteLine($"Calling double Plus(double, double)...");
            return a + b;
        }

        static double Plus(int a, double b)
        {

            Console.WriteLine($"Calling double Plus(int, double)...");
            return a + b;
        }

        static void Main7(string[] args)
        {

            Console.WriteLine(Plus(1, 2));      // int int
            Console.WriteLine(Plus(1, 2, 3));   // int int int
            Console.WriteLine(Plus(1.0, 2.4));  // double double
            Console.WriteLine(Plus(1, 2.4));    // int double
        }
    }
}
