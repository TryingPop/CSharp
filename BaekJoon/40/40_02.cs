#define Wrong

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 1. 21
이름 : 배성훈
내용 : CCW
    문제번호 : 11758번

    p1을 시작지점 p2를 끝점으로 하는 벡터를 dir1,
    p2을 시작지점 p3를 끝점으로 하는 벡터를 dir2로해서

    dir1에서 dir2로 이동하는 방향이 시계방향인지 반시계인지 확인하는 문제로 해석했었다
    문제 접근은 맞았으나 if문 설정을 잘못해서 여러번 틀렸다


*/

namespace BaekJoon._40
{
    internal class _40_02
    {

        static void Main2(string[] args)
        {

            int[] p1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] p2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] p3 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();



#if Wrong
            // 벡터로 비교하자
            int[] dir1 = GetDir(p1, p2);
            int[] dir2 = GetDir(p1, p3);

            Scale(dir1, dir2);

            // 계산
            Console.WriteLine(ChkDir(dir1, dir2));
#else

            // 걍 외적쓰자;
            int area = p1[0] * p2[1] + p2[0] * p3[1] + p3[0] * p1[1];
            area -= p1[0] * p3[1] + p2[0] * p1[1] + p3[0] * p2[1];

            if (area > 0) area = 1;
            else if (area < 0) area = -1;

            Console.WriteLine(area);
#endif
        }

#if Wrong
        static int[] GetDir(int[] _start, int[] _end)
        {

            int[] result = new int[2];

            result[0] = _end[0] - _start[0];
            result[1] = _end[1] - _start[1];

            return result;
        }

        static void Scale(int[] _dir1, int[] _dir2)
        {

            int scale1 = _dir1[0] < 0 ? -_dir1[0] : _dir1[0];
            int scale2 = _dir2[0] < 0 ? -_dir2[0] : _dir2[0];

            _dir1[0] *= scale2;
            _dir1[1] *= scale2;
            _dir2[0] *= scale1;
            _dir2[1] *= scale1;
        }

        static int ChkDir(int[] _dir1, int[] _dir2)
        {

            int p = 1;

            if (_dir1[0] == 0)
            {

                if (_dir1[1] < 0) p = -1;

                if (_dir2[0] > 0) return p * 1;
                if (_dir2[0] < 0) return p * -1;

                return 0;
            }

            if (_dir1[0] > 0)
            {

                if (_dir2[0] < 0)
                {

                    p = -1;
                    _dir2[1] = -_dir2[1];
                }

                if (_dir1[1] > _dir2[1]) return p * -1;
                if (_dir1[1] < _dir2[1]) return p * 1;

                return 0;
            }


            p = -1;
            // _dir1[0] < 0
            if (_dir2[0] > 0)
            {

                p = 1;
                _dir2[1] = -_dir2[1];
            }

            if (_dir1[1] > _dir2[1]) return p * -1;
            if (_dir1[1] < _dir2[1]) return p * 1;

            return 0;
        }
#endif
    }
}
