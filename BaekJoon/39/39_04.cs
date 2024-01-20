using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 1. 20
이름 : 배성훈
내용 : 우수 마을
    문제번호 : 1949번
*/

namespace BaekJoon._39
{
    internal class _39_04
    {

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int num = int.Parse(sr.ReadLine());

            // 인구
            int[] pop = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            // 1부터 시작
            List<int>[] lines = new List<int>[num + 1];

            for (int i = 1; i <= num; i++)
            {

                lines[i] = new();
            }

            // 트리의 간선 입력 받는다
            for (int i = 1; i < num; i++)
            {

                int[] temp = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                lines[temp[0]].Add(temp[1]);
                lines[temp[1]].Add(temp[0]);
            }

            sr.Close();

            int start = 1;

            if (lines[start].Count == 1) start = lines[start][0];

            // dp
            (int contain, int except, int diff, int parent)[] dp = new (int contain, int except, int diff, int parent)[num + 1];
            dp[start].parent = -1;


            ///
            /// 현재 수정 필요!
            /// 6
            /// 10 1 1 1 10 10
            /// 1 2
            /// 2 3
            /// 3 4
            /// 4 5
            /// 3 6
            /// 입력 받으면 30이 나와야하는데 21이 나온다
            /// 이는 시작지점이 리프라서 생긴다!
            ///


            DFS(lines, start, dp, pop);

            if (dp[start].contain > dp[start].except) Console.WriteLine(dp[start].contain);
            else Console.WriteLine(dp[start].except);
        }

        static void DFS(List<int>[] _lines, int _start, (int contain, int except, int diff, int parent)[] _dp, int[] _pop)
        {


            _dp[_start].contain += _pop[_start - 1];

            bool disConnect = _lines[_start].Count != 1;

            for (int i = 0; i < _lines[_start].Count; i++)
            {

                int next = _lines[_start][i];

                if (_dp[next].parent != 0) continue;
                _dp[next].parent = _start;
                DFS(_lines, next, _dp, _pop);

                _dp[_start].contain += _dp[next].except;
                bool chk = _dp[next].contain < _dp[next].except;


                if (!chk)
                {

                    _dp[_start].except += _dp[next].contain;
                    disConnect = false;
                }
                else _dp[_start].except += _dp[next].except;
            }

            // 연결 안된상태!
            if (disConnect)
            {

                int max = -50_000_000;

                for (int i = 0; i < _lines[_start].Count; i++)
                {

                    int next = _lines[_start][i];

                    if (next == _dp[_start].parent) continue;

                    if (max < _dp[next].diff) max = _dp[next].diff;
                }

                _dp[_start].except += max;
            }

            _dp[_start].diff = _dp[_start].contain - _dp[_start].except; 
        }
    }
}
