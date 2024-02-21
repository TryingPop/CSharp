using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 2. -
이름 : 배성훈
내용 : 방탈출
    문제번호 : 23352번

    재미있어 보이는 문제다!
    완전 탐색을 해야한다!
*/

namespace BaekJoon.etc
{
    internal class etc_0074
    {

        static void Main74(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int row = ReadInt(sr);
            int col = ReadInt(sr);

            int[,] board = new int[row, col];

            for (int r = 0; r < row; r++)
            {

                for (int c = 0; c < col; c++)
                {

                    board[r, c] = ReadInt(sr);
                }
            }
            sr.Close();

            int[,] dp = new int[row, col];

            // 최대 거리를 저장하자~
            Queue<(int r, int c)> q = new();


        }

        static bool ChkInvalidPos(int _r, int _c, int _row, int _col)
        {

            if (_r < 0 || _r >= _row) return true;
            if (_c < 0 || _c >= _col) return true;

            return false;
        }

        static int ReadInt(StreamReader _sr)
        {

            int ret = 0, c;

            while((c = _sr.Read()) != -1 && c != ' ' && c != '\n')
            {

                if (c == '\r') continue;
                ret = ret * 10 + c - '0';
            }

            return ret;
        }
    }
}
