using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 배열
    교재 p 360 ~ 362

    C# 8.0부터는 System.Index 형식과 ^ 연산자가 생겼다.
    ^ 연산자는 컬렉션의 마지막부터 역순으로 지정하는 기능을 갖고 있다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _02_ArraySample2
    {

        static void Main2(string[] args)
        {

            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[^2] = 90;
            scores[^1] = 34;

            foreach (int score in scores)
                Console.WriteLine(score);

            int sum = 0;
            foreach (int score in scores)
                sum += score;

            int average = sum / scores.Length;

            Console.WriteLine($"Average Score: {average}");
        }
    }
}
