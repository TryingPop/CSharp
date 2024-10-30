using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : if문 중첩해서 사용하기
    교재 150 ~ 152

    if 문 안에 if 문을 넣어 흐름을 제어하는게 중첩이다
    if문의 많은 중첩을 이용해 프로그램의 흐름을 나눌 수 있게 되었다
    하지만 너무 많은 중첩은 쉽게 읽기 힘들어 지양하는게 좋다

    내가 아닌 다른 누군가가 쉽게 읽을 수 있는 코드가 좋은 코드이며,
    이런 코드를 만들기 위해서는 단순하고 명료하게 작성하려는 노력이 필요하다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _02_IfIf
    {

        static void Main2(string[] args)
        {

            Console.Write("숫자를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number > 0)
            {

                if (number % 2 == 0)
                    Console.WriteLine("0보다 큰 짝수.");
                else
                    Console.WriteLine("0보다 큰 홀수.");
            }
            else
            {

                Console.WriteLine("0보다 작거나 같은 수.");
            }
        }
    }
}
