using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 29
이름 : 배성훈
내용 : continue
   교재 p 176 ~ 178

    반복문을 멈추게 하는 break문과 달리 continue 문은 한 회 건너 뛰어
    반복을 계속 수행하게 하는 기능을 한다

    continue 문이 반복문 안에 사용되면,
    현재 실행 중인 반복을 건너뛰고 다음 반복으로 넘어간다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _15_Continue
    {

        static void Main15(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                    continue;

                Console.WriteLine($"{i} : 홀수");
            }
        }
    }
}
