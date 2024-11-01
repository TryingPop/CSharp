using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 다차원 배열
    교재 p 375 ~ 377

    3차원 이상의 배열은 그림으로 그리기 어렵다.
    그래서 배열의 내용을 유지하는 것이 어려울 수 있다.

    머릿속에 내용을 유지할 수 없다면 버그가 충만한 코드로 이어질 수 있다.
    그래서 유지보수가 힘들고 지양해야한다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _08_3DArray
    {

        static void Main8(string[] args)
        {

            int[,,] array = new int[4, 3, 2]
            {

                { {1, 2}, {3, 4}, {5, 6} },
                { {1, 4}, {2, 5}, {3, 6} },
                { {6, 5}, {4, 3}, {2, 1} },
                { {6, 3}, {5, 2}, {4, 1} }
            };

            // { 1 2 } { 3 4 } { 5 6 }
            // { 1 4 } { 2 5 } { 3 6 }
            // { 6 5 } { 4 3 } { 2 1 }
            // { 6 3 } { 5 2 } { 4 1 }
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write("{ ");
                    for (int k = 0; k < array.GetLength(2); k++)
                    {

                        Console.Write($"{array[i, j, k]} ");
                    }

                    Console.Write("} ");
                }

                Console.WriteLine();
            }
        }
    }
}
