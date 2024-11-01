using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 가변 배열
    교재 p 378 ~ 380

    다차원 배열에서 배열을 요소로 갖는다 했는데, 진정한 의미에서 배열을 요소로 갖는 배열은 다차원 배열이다.
    가변 배열은 다양한 길이의 배열을 요소로 갖는 다차원 배열로 이용될 수 있다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _09_JaggedArray
    {

        static void Main9(string[] args)
        {

            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 200 };

            // Length: 5, 1 2 3 4 5
            // Length: 3, 10 20 30
            // Length: 2, 100 200
            foreach (int[] arr in jagged)
            {

                Console.Write($"Length: {arr.Length}, ");
                foreach (int e in arr)
                {

                    Console.Write($"{e} ");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("");

            int[][] jagged2 = new int[2][]
            {

                new int[] { 1000, 2000 },
                new int[4] { 6, 7, 8, 9 }
            };

            // Length: 2, 1000 2000
            // Length: 4, 6 7 8 9
            foreach (int[] arr in jagged2)
            {

                Console.Write($"Length: {arr.Length}, ");
                foreach(int e in arr)
                {

                    Console.Write($"{e} ");
                }

                Console.WriteLine();
            }
        }
    }
}
