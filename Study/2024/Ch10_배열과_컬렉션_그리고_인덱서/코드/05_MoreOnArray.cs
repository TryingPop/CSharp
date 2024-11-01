using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : System.Array
    교재 p 366 ~ 369

    Sort() : 배열 정렬
    BinarySearch() : 이진 탐색
    IndexOf() : 값에 대한 인덱스 찾기 앞에서부터 탐색
    TrueForAll() : 배열의 모든 요소가 지정한 조건에 부합하는지의 여부 반환
    FindIndex() : 조건에 대한 인덱스를 찾는다 앞에서부터 탐색
    Resize<T>() : 배열의 크기를 재조정
    Clear() : 배열의 모든 요소를 초기화한다. 숫자면 0, 논리면 false, 참조면 null
    ForEach<T>() : 배열의 모든 요소에 대해 동일한 작업을 수행한다.
    Copy<T>() : 배열의 일부를 다른 배열에 복사한다.

    GetLength() : 배열에서 지정한 차원의 길이를 반환한다.
    Length : 배열의 길이를 반환한다.
    Rank : 배열의 차원을 반환한다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _05_MoreOnArray
    {

        private static bool CheckPassed(int score)
        {

            return score >= 60;
        }

        private static void Print(int value)
        {

            Console.Write($"{value} ");
        }

        static void Main5(string[] args)
        {

            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            // 80 74 81 90 34
            foreach (int score in scores)
                Console.Write($"{score} ");

            Console.WriteLine();
            
            Array.Sort(scores);

            // 34 74 80 81 90
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            // Number of dimensions : 1
            Console.WriteLine($"Number of dimensions : {scores.Rank}");

            // Binary Search : 81 is at 3
            Console.WriteLine($"Binary Search : 81 is at " + 
                $"{Array.BinarySearch<int>(scores, 81)}");

            // Linear Search : 90 is at 4
            Console.WriteLine($"Linear Search : 90 is at " + 
                $"{Array.IndexOf(scores, 90)}");

            // Everyone passed ? : False
            Console.WriteLine($"Everyone passed ? : " + 
                $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            int index = Array.FindIndex<int>(scores, (score) => score < 60);

            scores[index] = 61;
            // Everyone passed ? : True
            Console.WriteLine($"Everyone passed ? : "
                + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            // Old length of scores : 5
            Console.WriteLine("Old length of scores : "
                + $"{scores.GetLength(0)}");

            // New length of scores : 10
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"New length of scores : {scores.Length}");

            // 61 74 80 81 90 0 0 0 0 0
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            // 61 74 80 0 0 0 0 0 0 0
            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);

            // 61 74 80
            Array.ForEach<int>(sliced, new Action<int>(Print));
            Console.WriteLine();
        }
    }
}
