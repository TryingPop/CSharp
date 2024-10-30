using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : return에 대하여
    교재 p 190 ~ 192

    return문은 점프문의 한 종류이다
    프로그램의 흐름을 갑자기 호출자에게로 돌려놓는다

    return 문은 언제든지 메소드 중간에 호출되어 메소드를 종결시키고 
    프로그램의 흐름을 호출자에게 돌려줄 수 있다

    메소드가 자신을 스스로 호출하는 것을 일컬어 재귀 호출(Recursive Call)이라 한다
    재귀 호출은 코드를 단순하게 구성할 수 있다는 장점이 있는 한편(재귀 호출이 없다면 반복문으로 구성해야 한다.)
    성능에는 나쁜 영향을 주기 때문에 주의해서 사용해야 한다
*/

namespace Study._2024.Ch06_메소드
{
    internal class _02_Return
    {

        static int Fibonacci(int n)
        {

            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone)
        {

            if (name == "")
            {

                Console.WriteLine("이름을 입력해주세요.");
                return;
            }

            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main2(string[] args)
        {

            Console.WriteLine($"10번째 피보나치 수 : {Fibonacci(10)}");    // 10번째 피보나치 수 : 55

            PrintProfile("", "123-4567");                                  // 이름을 입력해주세요.
            PrintProfile("박상현", "456-1230");                            // Name:박상현, Phone:456-1230
        }
    }
}
