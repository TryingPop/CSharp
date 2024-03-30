using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 3. 28
이름 : 배성훈
내용 : 도청 장치
    문제번호 : 9319번

    ...? 25%에서 틀린다
*/

namespace BaekJoon.etc
{
    internal class etc_0371
    {

        static void Main371(string[] args)
        {


            /*
            string NOISE = "NOISE";

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int test = ReadInt();
            decimal[] r = new decimal[100_000];
            (int x, int y, int s)[] tool = new (int x, int y, int s)[100_001];

            while (test-- > 0)
            {

                int n = ReadInt();
                int B = ReadInt();

                tool[0].x = ReadInt();
                tool[0].y = ReadInt();

                for (int i = 1; i <= n; i++)
                {

                    tool[i] = (ReadInt(), ReadInt(), ReadInt());
                }

                decimal total = 0;
                for (int i = 0; i < n; i++)
                {

                    r[i] = GetR(i);
                    total += r[i];
                }

                int ret = 0;
                for (int i = 0; i < n; i++)
                {

                    decimal curR = r[i];
                    decimal comp = 6 * (B + total - curR);

                    if (curR > comp) ret++;
                }

                if (ret == 0) sw.WriteLine(NOISE);
                else sw.WriteLine(ret);
            }

            sr.Close();
            sw.Close();

            decimal GetR(int _idx)
            {

                _idx++;
                int dis = (tool[0].x - tool[_idx].x) * (tool[0].x - tool[_idx].x);
                dis += (tool[0].y - tool[_idx].y) * (tool[0].y - tool[_idx].y);
                decimal ret = tool[_idx].s;
                ret /= dis;

                return ret;
            }

            int ReadInt()
            {

                int c, ret = 0;
                while ((c = sr.Read()) != -1 && c != ' ' && c != '\n')
                {

                    if (c == '\r') continue;
                    ret = ret * 10 + c - '0';
                }

                return ret;
            }

            */

           
        }
    }
}
