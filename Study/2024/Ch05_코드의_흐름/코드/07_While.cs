using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : while 문
    교재 p 162 ~ 164

    반복문에 관한 내용이다
    C#에서 반복문은 크게 4가지 방법이 있다
        while
        do while
        for
        foreach

    먼저 while문을 확인하자
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _07_While
    {

        static void Main7(string[] args)
        {

            int i = 10;

            while (i > 0)
            {

                Console.WriteLine($"i : {i--}");
            }
        }
    }
}
