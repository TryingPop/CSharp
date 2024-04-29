using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. -
이름 : 배성훈
내용 : 달이 차오른다, 가자.
    문제번호 : 1194번
*/

namespace BaekJoon.etc
{
    internal class etc_0650
    {

        static void Main(string[] args)
        {

            StreamReader sr;
            int row, col;
            int[][] map;
            int[][][] dp;
            bool[][][] visit;

            Queue<(int r, int c, int key)> q;

            Solve();

            void Solve()
            {

                Input();

            }

            void Input()
            {

                sr = new(Console.OpenStandardInput(), bufferSize: 65536);
                row = ReadInt();
                col = ReadInt();
                map = new int[row][];
                dp = new int[64][][];
                visit = new bool[64][][];

                for (int i = 0; i < 64; i++)
                {

                    dp[i] = new int[row][];
                    visit[i] = new bool[row][];
                }

                for (int r = 0; r < row; r++)
                {

                    for (int i = 0; i < 64; i++)
                    {

                        dp[i][r] = new int[col];
                        visit[i][r] = new bool[col];
                    }

                    map[r] = new int[col];

                    for (int c = 0; c < col; c++)
                    {

                        map[r][c] = sr.Read();
                    }

                    if (sr.Read() == '\r') sr.Read();
                }

                sr.Close();
            }

            int ReadInt()
            {

                int c, ret = 0;
                while((c = sr.Read()) != -1 && c != ' ' && c != '\n')
                {

                    if (c == '\r') continue;
                    ret = ret * 10 + c - '0';
                }

                return ret;
            }
        }
    }
}
