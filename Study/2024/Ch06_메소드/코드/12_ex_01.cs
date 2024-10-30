using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 연습문제 1
    교재 p 216

    다음 코드에서 Square() 메소드를 구현해 프로그램을 완성하세요. Square() 함수는 매개변수를 제곱하여 반환한다. 프로그램 실행 예는 다음과 같다.

        수를 입력하세요: 3
        결과: 9

        수를 입력하세요: 34.2
        결과: 1169.64


    코드
        using System;

        static double Square(double arg)
        {

            // 이 메소드를 구현해주세요.
        }

        static void Main(string[] args)
        {

            Console.Write("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
*/

namespace Study._2024.Ch06_메소드.코드
{
    internal class _12_ex_01
    {

        static double Square(double arg)
        {

            return arg * arg;
        }

        static void Main12(string[] args)
        {

            Console.Write("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));
        }
    }
}
