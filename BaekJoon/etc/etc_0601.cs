using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. 22
이름 : 배성훈
내용 : 배열 돌리기 4
    문제번호 : 17406번
*/

namespace BaekJoon.etc
{
    internal class etc_0601
    {

        static void Main601(string[] args)
        {

            StreamReader sr;
            StreamWriter sw;

            int row, col;
            int[][][] board;
            int[][] rots;
            int op;
            Solve();

            void Solve()
            {

                Input();
            }

            void Input()
            {

                sr = new(Console.OpenStandardInput(), bufferSize: 65536 * 8);
                row = ReadInt();
                col = ReadInt();

                op = ReadInt();
                board = new int[3][][];

                // 2번이 회전 시킨 결과
                // 1번은 연산용
                // 0번은 초기 상태확인용도!
                board[0] = new int[row][];
                board[1] = new int[row][];
                board[2] = new int[row][];

                for (int r = 0; r < row; r++)
                {

                    board[0][r] = new int[col];
                    board[1][r] = new int[col];
                    board[2][r] = new int[col];

                    for (int c = 0; c < col; c++)
                    {

                        board[0][r][c] = ReadInt();
                    }
                }

                rots = new int[op][];
                for (int i = 0; i < op; i++)
                {

                    rots[i] = new int[3];
                    for (int j = 0; j < 3; j++)
                    {

                        rots[i][j] = ReadInt();
                    }
                }

                sr.Close();
            }

            void Copy(int _f, int _t)
            {

                for (int i = 0; i < row; i++)
                {

                    for (int j = 0; j < col; j++)
                    {

                        board[_t][i][j] = board[_f][i][j];
                    }
                }
            }

            void Rotate(int _rotIdx)
            {

                // board[1]에 값으로 -> board[2]로 연산
                for (int size = rots[_rotIdx][2]; size >= 2; size--)
                {


                }
            }

            int GetMin()
            {

                int ret = 0;
                for (int c = 0; c < col; c++)
                {

                    ret += board[2][0][c];
                }

                for (int r = 1; r < row; r++)
                {

                    int calc = 0;
                    for (int c = 0; c < col; c++)
                    {

                        calc += board[2][r][c];
                    }

                    ret = calc < ret ? calc : ret;
                }

                return ret;
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
