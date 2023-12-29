using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 12. 29
이름 : 배성훈
내용 : 벽 부수고 이동하기
    문제번호 : 2206번
*/

namespace BaekJoon._32
{
    internal class _32_15
    {

        static void Main(string[] args)
        {

            int[] info;
            int[][] board;
            using (StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
            {

                info = sr.ReadLine().Split(' ').Select(int.Parse).ToArray();
                board = new int[info[0]][];

                for (int i = 0; i < info[0]; i++)
                {

                    string temp = sr.ReadLine();

                    board[i] = new int[info[1]];

                    for (int j = 0; j < info[1]; j++)
                    {

                        // 갈 수 있는 길 -1, 벽 0
                        board[i][j] = temp[j] - '1';
                    }
                }
            }

            int[][] dir = new int[2][];
            dir[0] = new int[] { -1, 1, 0, 0 };
            dir[1] = new int[] { 0, 0, -1, 1 };
        }

        static bool ChkInValidPos(int _x, int _y, int[] _size)
        {

            if (_x < 0 || _x >= _size[0]) return true;
            if (_y < 0 || _y >= _size[1]) return true;

            return false;
        }

        static void DFS(int[][] _board, int[] _size, int[][] _dir, ref int _result, int _step = 1, int _x = 0, int _y = 0, bool _broken = false, bool[][] _chk = null)
        {

            // DFS 로 체크?
            if (_chk == null) 
            { 
                
                _chk = new bool[_size[0]][]; 
            
                for (int i = 0; i < _size[0]; i++)
                {

                    _chk[i] = new bool[_size[1]];
                }
            }

            _board[_x][_y] = _step;

            

            for (int i = 0; i < 4; i++)
            {

                int x = _x + _dir[0][i];
                int y = _y + _dir[1][i];

                if (ChkInValidPos(x, y, _size)) continue;
                if (_board[x][y] == 0)
                {

                    // 이미 부셨다면 넘긴다
                    if (_broken) continue;

                    _broken = true;

                    DFS(_board, _size, _dir, ref _result, _step + 1, x, y, _broken, _chk);

                    _broken = false;
                    _board[x][y] = 0;
                }
                else if (_board[x][y] == -1)
                {

                    DFS(_board, _size, _dir, ref _result, _step + 1, x, y, _broken, _chk);
                    _board[x][y] = -1;
                }
            }
        }
    }
}
