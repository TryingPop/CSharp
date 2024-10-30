using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 29
이름 : 배성훈
내용 : 연습문제 2
    교재 p 182

    다음과 같은 결과를 출력하는 프로그램을 for 문을 이용하여 작성하세요.

        *****
        ****
        ***
        **
        *
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _18_ex_02
    {

        static void Main18(string[] args)
        {

            for (int i = 5; i > 0; i--)
            {

                for (int j = 0; j < i; j++)
                {

                    Console.Write('*');
                }

                Console.Write('\n');
            }
        }
    }
}
