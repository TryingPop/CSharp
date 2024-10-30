using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 가변 개수의 인수
    교재 p 206 ~ 208

    가변 개수의 인수는 같은 형식의 인수의 개수만 달라지는 경우
    사용하면 좋은 방법이다.

    사용 방법은 params와 배열을 이용해 사용한다.

    오버로딩은 형식이 다른 매개변수에도 사용할 수 있어
    가변 개수의 인수가 못하는 기능도 한다
*/

namespace Study._2024.Ch06_메소드.코드
{
    internal class _08_UsingParams
    {

        static int Sum(params int[] args)
        {

            Console.WriteLine("Summing...");

            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {

                if (i > 0)
                    Console.Write(", ");

                Console.Write(args[i]);

                sum += args[i];
            }

            Console.WriteLine();
            return sum;
        }

        static void Main8(string[] args)
        {

            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10); // Summing... 3, 4, 5, 6, 7, 8, 9, 10
            Console.WriteLine($"Sum : {sum}");      // 52
        }
    }
}
