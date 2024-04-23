using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. 23
이름 : 배성훈
내용 : 사랑의 큐피드
    문제번호 : 30976번

    이분 매칭 문제다
    경우의 수가 300, 300이므로, 완전탐색 300 * 300 = 90_000으로
    간선을 놓고 이분 매칭을 진행해서 풀었다
    초과, 미만 부분을 이상, 이하로 해서 3번 틀렸다
    그리고 인덱스 에러로 1번 틀렸다
*/

namespace BaekJoon.etc
{
    internal class etc_0602
    {

        static void Main602(string[] args)
        {

            StreamReader sr;

            int n, m;
            int[] match;
            bool[] visit;

            List<int>[] line;

            Solve();

            void Solve()
            {

                Input();

                int ret = 0;
                for (int i = 1; i <= n; i++)
                {

                    Array.Fill(visit, false);
                    if (DFS(i)) ret++;
                }

                Console.WriteLine(ret);
            }

            void Input()
            {

                sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
                n = ReadInt();
                m = ReadInt();
                int[] girl = new int[n + 1];
                line = new List<int>[n + 1];
                for (int i = 1; i <= n; i++)
                {

                    girl[i] = ReadInt();
                    line[i] = new();
                }

                int[] boy = new int[m + 1];
                for (int i = 1; i <= m; i++)
                {

                    boy[i] = ReadInt();
                }

                int[] want = new int[n + 1];
                for (int i = 1; i <= n; i++)
                {
                    want[i] = ReadInt();
                }

                for (int b = 1; b <= m; b++)
                {

                    int cur = ReadInt();

                    for (int g = 1; g <= n; g++)
                    {

                        if (boy[b] >= want[g] || girl[g] <= cur) continue;
                        line[g].Add(b);
                    }
                }

                match = new int[m + 1];
                visit = new bool[m + 1];

                sr.Close();
            }

            bool DFS(int _n)
            {

                for (int i = 0; i < line[_n].Count; i++)
                {

                    int next = line[_n][i];
                    if (visit[next]) continue;
                    visit[next] = true;

                    if (match[next] == 0 || DFS(match[next]))
                    {

                        match[next] = _n;
                        return true;
                    }
                }
                return false;
            }

            int ReadInt()
            {

                int c, ret = 0;
                while ((c = sr.Read()) != -1 && c != ' ' && c != '\n')
                {

                    if (c == '\r') continue;
                    ret = ret * 10 + c - '0';
                }

                return ret;
            }
        }
    }
}
