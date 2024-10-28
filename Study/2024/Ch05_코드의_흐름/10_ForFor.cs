using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : 중첩 for
    교재 p 169 ~ 

    for문 안에 for문을 넣는 것이다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _10_ForFor
    {

        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j <= i; j++)
                {

                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}
