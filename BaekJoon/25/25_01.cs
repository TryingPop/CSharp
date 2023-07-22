using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 22
이름 : 배성훈
내용 : N과 M (1)
    문제번호 : 15649번

    자연수 n m 이 주어졌을 때
    1 ~ n까지의 수를 서로 다른 순서를 고려해서 서로 다른 m개를 나열
    즉, nPm개 경우의 수를 모두 구해라

    
*/

namespace BaekJoon._25
{
    internal class _25_01
    {

        static void Main1(string[] args)
        {
#if first
            int[] info = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[,] board = new int[info[0] + 1, info[1] + 1];
            bool[] chk = new bool[info[0] + 1];

            for (int i = 1; i <= info[0]; i++)
            {

                for (int j = 1; j <= info[1]; j++)
                {

                    board[i, j] = i;
                }
            }

            Back(board, chk);
#elif true
#endif
        }
#if first
        // 재귀를 이용한 백트래킹
        // 시간이 엄청 걸린다(최고속의 20배), 메모리(최고속의 3배)도 많이 잡아 먹는다
        // 다른사람이 푼 것을 보니 DFS로 풀어나갔따
        // 보드를 너무 크게 설정했다
        static void Back(int[,] board, bool[] chk, int step = 0, string str = "")
        {

            if (step >= board.GetLength(1) - 1)
            {

                Console.WriteLine(str);
                return;
            }

            for (int i = 1; i <= board.GetLength(0) - 1; i++)
            {

                if (chk[i] == false)
                {

                    chk[i] = true;
                    

                    Back(board, chk, step + 1, $"{str}{i} ");
                    
                    chk[i] = false;
                }
            }
        }
#elif true
        // 클래스로 표현했고
        // 크기도 더 간결해졌다
        // 또한 입출력 버퍼를 통해 더 빠른거 같아 보인다
        public class PS
        {

            private static StreamWriter sw;

            private readonly int n;
            private readonly int m;

            private bool[] visited;
            private int[] ans;

            public PS(int n, int m)
            {

                if (sw == null) sw = new StreamWriter(Console.OpenStandardOutput());

                this.n = n;
                this.m = m;
                visited = new bool[n + 1];
                ans = new int[m];
            }

            public void Solve()
            {


                DFS(0);
                sw.Close();
            }

            public void DFS(int depth)
            {

                if (depth == m)
                {

                    for (int i = 0; i < m; i++)
                    {

                        sw.Write(string.Join(' ', this.ans));
                    }

                    sw.Write('\n');
                    return;
                }
                
                for (int i = 0; i <= n; i++)
                {

                    if (!visited[i])
                    {

                        visited[i] = true;

                        ans[depth] = i;
                        DFS(depth + 1);

                        visited[i] = false;
                    }
                }
            }
        }
#endif
    }
}
