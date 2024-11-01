using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 2차원 배열
    교재 p 372 ~ 375

    2차원 배열은 1차원 배열을 원소로 갖는 배열으로 볼 수 있다.
    2차원 배열은 1차원 배열과 선언 형식이 같지만 각 차원의 용량 또는 길이를 (,)로 구분해서 []사이에 입력한다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _07_2DArray
    {

        static void Main7(string[] args)
        {

            // [0, 0] : 1 [0, 1] : 2 [0, 2] : 3
            // [1, 0] : 4 [1, 1] : 5 [1, 2] : 6
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    Console.Write($"[{i}, {j}] : {arr[i, j]} ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            // [0, 0] : 1 [0, 1] : 2 [0, 2] : 3
            // [1, 0] : 4 [1, 1] : 5 [1, 2] : 6
            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < arr2.GetLength(0); i++)
            {

                for (int j = 0; j < arr2.GetLength(1); j++)
                {

                    Console.Write($"[{i}, {j}] : {arr2[i, j]} ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            // [0, 0] : 1 [0, 1] : 2 [0, 2] : 3
            // [1, 0] : 4 [1, 1] : 5 [1, 2] : 6
            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < arr3.GetLength(0); i++)
            {

                for (int j = 0; j < arr3.GetLength(1); j++)
                {

                    Console.Write($"[{i}, {j}] : {arr3[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
