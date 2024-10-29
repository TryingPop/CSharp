using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 29
이름 : 배성훈
내용 : goto
    교재 p 178 ~ 181

    goto 문의 사용형식에서 레이블에 주목하길 바란다
    레이블은 코드 안의 위치를 나타내는표지판 같은 존재다

    goto 문은 레이블이 가리키는 곳으로 바로 뛰어넘어간다

    return과 throw는 배경지식이 필요하기에 다른 장에서 설명한다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _16_Goto
    {

        static void Main16(string[] args)
        {

            Console.WriteLine("종료 조건(숫자)을 입력하세요 : ");

            String input = Console.ReadLine();

            int input_number = Convert.ToInt32(input);
            int exit_number = 0;

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 2; j++)
                {

                    for (int k = 0; k < 3; k++)
                    {

                        if (exit_number == input_number)
                            goto EXIT_FOR;

                        Console.WriteLine(exit_number);
                    }
                }
            }

            goto EXIT_PROGRAM;

            EXIT_FOR:
                Console.WriteLine("\nExit nested for...");

            EXIT_PROGRAM:
                Console.WriteLine("Exit program...");
        }
    }
}
