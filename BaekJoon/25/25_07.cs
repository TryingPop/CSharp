using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 25
이름 : 배성훈
내용 : 연산자 끼워넣기
    문제번호 : 14888번
*/

namespace BaekJoon._25
{
    internal class _25_07
    {

        static void Main7(string[] args)
        {

            int len = int.Parse(Console.ReadLine());

            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] opNum = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);   // +, -, *, /

            int min = int.MaxValue, max = int.MinValue;


        }

        // 모든 경우의 수 따져야하는데 .. ? 
        // 탈출을 어떻게?
        // 1. 곱셈 유무 맨 뒤는 곱셈이 와야할거 같다!
        // 그리고 DFS가 아닌 BFS 방법의 탐색이 필요한거 같은데?..? 그래서 가지치기
        // 그래야 진행하면서 같은 개수를써도 가지치기가 될거 같다?

    }
}
