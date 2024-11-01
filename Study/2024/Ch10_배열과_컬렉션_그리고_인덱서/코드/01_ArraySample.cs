using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 배열
    교재 p 356 ~ 360

    프로그램을 작성하다 보면 같은 성격을 띤 다수의 데이터를 한번에 다뤄야 하는 경우가 자주 생긴다.
    수가 작은 경우 일일히 변수를 세팅하는 방법이 있다.
    그런데 수가 변하거나 일일히 작성하기에는 많다면 부담된다.
    배열은 이런 문제를 해결해준다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _01_ArraySample
    {

        static void Main1(string[] args)
        {

            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            foreach(int score in scores)
                Console.WriteLine(score);

            int sum = 0;
            foreach (int score in scores)
                sum += score;

            int average = sum / scores.Length;

            Console.WriteLine($"Average Score: {average}");
        }
    }
}
