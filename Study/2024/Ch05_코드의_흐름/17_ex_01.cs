using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 29
이름 : 배성훈
내용 : 연습문제 1
    교재 p 182

    다음과 같은 결과를 출력하는 프로그램을 for문을 이용하여 작성하세요.
    규칙은 첫 번째 줄에 별 하나, 두 번째 줄에 별 둘, 세 번째 줄에 별 셋... 이런 식으로 5개의 별이 찍힐 때까지 반복합니다.
    (힌트 : for문 블록 안에 for문 블록을 넣으세요).

        *
        **
        ***
        ****
        *****
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _17_ex_01
    {

        static void Main17(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j <= i; j++)
                {

                    Console.Write('*');
                }

                Console.Write('\n');
            }
        }
    }
}
