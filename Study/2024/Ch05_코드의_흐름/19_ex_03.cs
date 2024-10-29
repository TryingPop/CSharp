using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 29
이름 : 배성훈
내용 : 연습문제 3
    교재 p 182

    1번과 2번을 for문 대신 while 문과 do 문으로 바꿔서 각각 작성하세요.
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _19_ex_03
    {

        static void Main19(string[] args)
        {

            Console.WriteLine("while 문으로 연습문제 1번 출력");
            int i = 0;
            while (i < 5)
            {

                i++;
                for (int j = 0; j < i; j++)
                {

                    Console.Write('*');
                }

                Console.Write('\n');
            }

            Console.WriteLine("\nwhile 문으로 연습문제 2번 출력");
            while (i > 0)
            {

                for (int j = 0; j < i; j++)
                {

                    Console.Write('*');
                }

                Console.Write('\n');
                i--;
            }

            Console.WriteLine("\ndo 문으로 연습문제 1번 출력");
            do
            {

                i++;
                for (int j = 0; j < i; j++)
                {

                    Console.Write('*');
                }

                Console.Write('\n');
            } while (i < 5);

            Console.WriteLine("\ndo 문으로 연습문제 2번 출력");
            do
            {

                for (int j = 0; j < i; j++)
                {

                    Console.Write('*');
                }

                Console.Write('\n');
                i--;
            } while (i > 0);

        }
    }
}
