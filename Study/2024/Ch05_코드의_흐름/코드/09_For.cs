using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : for 문
    교재 p 167 ~ 168

    for문은
        for (초기화식; 조건식; 반복식;)
            반복실행할 코드;

    형식으로 이뤄져 있다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _09_For
    {

        static void Main9(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine(i);
            }
        }
    }
}
