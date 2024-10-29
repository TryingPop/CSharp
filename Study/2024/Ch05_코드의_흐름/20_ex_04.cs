using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 29
이름 : 배성훈
내용 : 연습문제 4
    교재 p 182

    다음과 같이 사용자로부터 입력받은 횟수만큼 별을 반복 출력하는 프로그램을 작성하세요.
    단, 입력받은 수가 0보다 작거나 같을 경우 
    "0보다 같거나 작은 숫자는 사용할 수 없습니다."라는 메시지를 띄우고 프로그램을 종료합니다.

        반복 횟수를 입력하세요 : -10
        0보다 작거나 같은 수는 입력할 수 없습니다.

        반복 횟수를 입력하세요 : 5

        *
        **
        ***
        ****
        *****
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _20_ex_04
    {

        static void Main(string[] args)
        {

            Console.WriteLine("반복 횟수를 입력하세요 : -10");
            string input = Console.ReadLine();

            int num = int.Parse(input);

            if (num > 0)
            {

                Console.Write('\n');
                for (int i = 0; i < num; i++)
                {

                    for (int j = 0; j <= i; j++)
                    {

                        Console.Write('*');
                    }

                    Console.Write('\n');
                }
            }
            else Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
        }
    }
}
