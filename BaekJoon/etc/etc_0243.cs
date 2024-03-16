using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 3. 16
이름 : 배성훈
내용 : 원숭이 땅을 옮기다
    문제번호 : 1425번

    현재 정답 도출까지 로직이 조금 더 필요하다!
*/

namespace BaekJoon.etc
{
    internal class etc_0243
    {

        static void Main243(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int n = ReadInt(sr);

            (int x, int y)[] monkeys = new (int x, int y)[n];

            int[] chks = new int[n];

            for (int i = 0; i < n; i++)
            {

                int x = ReadInt(sr);
                int y = ReadInt(sr);

                monkeys[i] = (x, y);

                chks[i] = y;
            }

            sr.Close();

            long ret = 5_000_000_000;
            for (int h = 0; h < n; h++)
            {

                long max = 0;

                for (int i = 0; i < n; i++)
                {

                    for (int j = i + 1; j < n; j++)
                    {

                        long chk = GetDis(monkeys[i], monkeys[j], chks[h]);
                        if (max < chk) max = chk;
                    }
                }

                if (max < ret) ret = max;
            }

            Console.WriteLine(ret);
        }

        static long GetDis((int x, int y) _pos1, (int x, int y) _pos2, long _height)
        {

            long ret = 0;

            long h1 = _pos1.y - _height;
            h1 = h1 < 0 ? -h1 : h1;

            long h2 = _pos2.y - _height;
            h2 = h2 < 0 ? -h2 : h2;

            long w = _pos1.x - _pos2.x;
            w = w < 0 ? -w : w;

            ret = h1 + h2 + w;
            return ret;
        }

        static int ReadInt(StreamReader _sr)
        {

            int c, ret = 0;
            bool plus = true;

            while((c = _sr.Read()) != -1 && c != ' ' && c != '\n')
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
