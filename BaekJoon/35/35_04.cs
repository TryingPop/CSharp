using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 1. 10
이름 : 배성훈
내용 : 경찰차
    문제번호 : 2618번

*/

namespace BaekJoon._35
{
    internal class _35_04
    {

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int size = int.Parse(sr.ReadLine());
            int len = int.Parse(sr.ReadLine());

            int[][] pos = new int[len][];

            for (int i = 0; i < len; i++)
            {

                int[] temp = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                pos[i] = temp;
            }

            sr.Close();

            int[][] police = new int[2][];

            police[0] = new int[2] { 1, 1 };
            police[1] = new int[2] { size, size };

            int[][] board = new int[len + 1][];

            for (int i = 0; i < len + 1; i++)
            {

                board[i] = new int[len + 1];

            }

            

            // 이제 탐색 시작

            for (int cur = 2; cur <= len; cur++)
            {

                for (int other = 0; other < cur - 1; other++)
                {


                }
            }
        }

        static int Dis(int[][] _roots, int _start, int _end)
        {

            int dis = 0;

            for (int i = _start; i < _end; i++)
            {

                dis += TaxiDis(_roots[i + 1], _roots[i]);
            }

            return dis;
        }

        static int TaxiDis(int[] _pos1, int[] _pos2)
        {

            int result = 0;

            if (_pos1[0] > _pos2[0]) result += _pos1[0] - _pos2[0];
            else result += _pos2[0] - _pos1[0];

            if (_pos1[1] > _pos2[1]) result += _pos1[1] - _pos2[1];
            else result += _pos2[1] - _pos1[1];

            return result;
        }
    }
}
