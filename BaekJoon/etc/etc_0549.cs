using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. -
이름 : 배성훈
내용 : 회의실 배정 4
    문제번호 : 19623번

    힌트 보니 이분 탐색 문제다
    세그먼트 트리로 접근해야겠다
*/

namespace BaekJoon.etc
{
    internal class etc_0549
    {

        static void Main549(string[] args)
        {

            StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            int n;
            (int s, int e, int w)[] arr;
            int[] dp;
            Solve();

            void Solve()
            {

                Input();
                CompactPos();
            }

            void Input()
            {

                n = ReadInt();
                arr = new (int s, int e, int w)[n];

                for (int i = 0; i < n; i++)
                {

                    arr[i] = (ReadInt(), ReadInt(), ReadInt());
                }

                dp = new int[2 * n];
                Array.Fill(dp, -1);
            }

            void CompactPos()
            {

                int[] pos = new int[2 * n];

                for (int i = 0; i < n; i++)
                {

                    pos[2 * i] = arr[i].s;
                    pos[2 * i + 1] = arr[i].e;
                }

                Array.Sort(pos);

                for (int i = 0; i < n; i++)
                {

                    arr[i].s = FindIdx(pos, arr[i].s);
                    arr[i].e = FindIdx(pos, arr[i].e);
                }

                Array.Sort(arr, (x, y) =>
                {

                    int ret = x.s.CompareTo(y.s);
                    if (ret != 0) return ret;

                    return x.e.CompareTo(y.e);
                });
            }

            int FindIdx(int[] _sortedArr, int _chkVal)
            {

                int l = 0;
                int r = 2 * n - 1;

                while (l <= r)
                {

                    int mid = (l + r) / 2;

                    if (_sortedArr[mid] < _chkVal) l = mid + 1;
                    else r = mid - 1;
                }

                return r + 1;
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
