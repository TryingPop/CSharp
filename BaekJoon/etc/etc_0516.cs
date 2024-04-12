using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. 12
이름 : 배성훈
내용 : 카잉 달력
    문제번호 : 6064번
*/

namespace BaekJoon.etc
{
    internal class etc_0516
    {

        static void Main516(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int test = ReadInt();

            while(test-- > 0)
            {

                int m1 = ReadInt();
                int m2 = ReadInt();

                int y1 = ReadInt() - 1;
                int y2 = ReadInt() - 1;

                if (m1 < m2)
                {

                    int temp = m1;
                    m1 = m2;
                    m2 = temp;

                    temp = y1;
                    y1 = y2;
                    y2 = temp;
                }

                int gcd = GetGCD(m1, m2, out int r1, out int r2);
                if (ChkInvalidRet(y1, y2, gcd))
                {

                    sw.WriteLine(-1);
                    continue;
                }

                int ret = y1 * m2 + y2 * m1;
                ret %= m1 * m2 / gcd;
                if (ret < 0) ret += (m1 * m2) / gcd;

                sw.WriteLine(ret + 1);
            }

            sr.Close();
            sw.Close();

            bool ChkInvalidRet(int _y1, int _y2, int _gcd)
            {

                int diff = _y1 - _y2;
                diff = diff < 0 ? -diff : diff;

                return diff % _gcd != 0;
            }

            int GetGCD(int _a, int _b, out int _rA, out int _rB)
            {

                int r0 = _a;
                int r1 = _b;
                int s0 = 1;
                int s1 = 0;
                int t0 = 0;
                int t1 = 1;
                int temp = 0;
                int q = 0;

                while(r1 > 0)
                {

                    q = r0 / r1;

                    temp = r0;
                    r0 = r1;
                    r1 = temp - r1 * q;

                    temp = s0;
                    s0 = s1;
                    s1 = temp - s1 * q;

                    temp = t0;
                    t0 = t1;
                    t1 = temp - t1 * q;
                }

                _rA = s0;
                _rB = t0;
                return r0;
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
