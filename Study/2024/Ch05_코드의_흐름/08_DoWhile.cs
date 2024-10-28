using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : do while문
    교재 p 164 ~ 166

    최소 한 번은 실행해야하는 반복문에 사용하는게 좋다
*/

namespace Study._2024.Ch05_코드의_흐름
{
    internal class _08_DoWhile
    {

        static void Main8(string[] args)
        {

            int i = 10;

            do
            {

                // 10 ~ 1
                Console.WriteLine("a) i : {0}", i--);
            }
            while (i > 0);

            do
            {

                // 0
                Console.WriteLine("b) i : {0}", i--);
            }
            while (i > 0);
        }
    }
}
