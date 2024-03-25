using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 3. -
이름 : 배성훈
내용 : 사과나무
    문제번호 : 20002번
*/

namespace BaekJoon.etc
{
    internal class etc_0351
    {

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int n = ReadInt();

            int[,] board = new int[n, n];

            for (int r = 0; r < n; r++)
            {

                for (int c = 0; c < n; c++)
                {

                    board[r, c] = ReadInt();
                }
            }

            sr.Close();

            int[,] rSum = new int[n + 1, n + 1];
            int[,] cSum = new int[n + 1, n + 1];

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    cSum[i + 1, j + 1] = board[i, j];
                    cSum[i + 1, j + 1] += cSum[i + 1, j];

                    rSum[j + 1, i + 1] = board[j, i];
                    rSum[j + 1, i + 1] += rSum[j, i + 1];
                }
            }

            int max = -1_000;

            for (int i = 1; i <= n; i++)
            {

                int first = 0;
                for (int j = 0; j < i; j++)
                {

                    first += cSum[i, j + 1];
                }


                for (int r = 0; r <= n - i; r++)
                {

                    if (r > 0)
                    {


                    }

                    int calc = first;

                    if (max < calc) max = calc;
                    for (int c = 1; c <= n - i; c++)
                    {


                    }
                }
            }


            int ReadInt()
            {

                int c, ret = 0;
                bool plus = true;
                while((c = sr.Read()) != -1 && c != ' ' && c != '\n')
                {

                    if (c == '\r') continue;
                    else if (c == '-')
                    {

                        plus = false;
                        continue;
                    }

                    ret = ret * 10 + c - '0';
                }

                return plus ? ret : -ret;
            }
        }
    }
}
