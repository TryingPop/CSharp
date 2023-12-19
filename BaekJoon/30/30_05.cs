using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 12. 18
이름 : 배성훈
내용 : 동전 1
    문제번호  : 2293번

    동전 만들기
    메모리 제한 4mb << 너무 많이 쓰면 안된다! 
    1, 2, 5만 놓고 보자
    10 만드는 방법
    1 * 10
    1 * 8, 2 * 1
    1 * 6, 2 * 2
    1 * 4, 2 * 3
    1 * 2, 2 * 4
    2 * 5

    5 + 5
    1 * 5, 5 * 1
    1 * 3, 2 * 1, 5 * 1
    1 * 1, 2 * 2, 5 * 1
    5 * 2

    답이 안보인다
    2, 3, 5를 놓고 보자;

    2 * 5
    2 * 2, 3 * 2
    2 * 1, 3 * 1, 5 * 1
    5 * 2

    ... 여전히 안보인다

*/

namespace BaekJoon._30
{
    internal class _30_05
    {

        static void Main(string[] args)
        {

            // 입력 - 동전 개수, 목표 동전
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int[] info = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] coins = new int[info[0]];

            for(int i = 0; i < info[0]; i++)
            {

                coins[i] = int.Parse(sr.ReadLine());
            }

            sr.Close();



            // 출력

        }
    }
}
