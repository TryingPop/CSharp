using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 미정;
이름 : 배성훈
내용 : 공약수(More Huge)
    문제번호 : 27521번
    https://www.acmicpc.net/problem/27521 

    많아야 17개 소수
    2 * 3 * 5 * 7 * 11 * 13 * 17 * 19 * 23 * 29 * 31 = 614,889,782,588,491,410
    일단 쓰는 메모를 보고 알고리즘을 확인했다;

    세 수의 합부터 풀고 이번 달? 안에 풀 수 있게 노력해보자!

    일단 도전! -> 시간 초과다
    -> 실상 Meet In Middle 아이디어도 안썼다;
*/

namespace BaekJoon.etc
{
    internal class etc_0100
    {

        static void Main100(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int test = ReadInt(sr);
            StringBuilder sb = new StringBuilder(20 * test);
            Dictionary<long, long> lcmDic = new Dictionary<long, long>(20);
            Dictionary<long, long> gcdDic = new Dictionary<long, long>(20);
            List<long> calc = new List<long>(20);
            long[] ret = new long[2];

            List<(long fst, long sec)> left = new List<(long fst, long sec)>(1 << 8);
            List<(long fst, long sec)> right = new List<(long fst, long sec)>(1 << 8);

            while(test-- > 0)
            {

                int len = ReadInt(sr);

                long lcm = 1;
                for (int i = 0; i < len; i++)
                {

                    long cur = ReadLong(sr);
                    lcm *= cur;

                    if (lcmDic.ContainsKey(cur)) lcmDic[cur] *= cur;
                    else lcmDic[cur] = cur;
                }

                len = ReadInt(sr);
                for (int i = 0; i <len; i++)
                {

                    long cur = ReadLong(sr);

                    if (gcdDic.ContainsKey(cur)) gcdDic[cur] *= cur;
                    else gcdDic[cur] = cur;
                }

                foreach(var key in lcmDic.Keys)
                {

                    gcdDic[key] /= lcmDic[key];
                }

                int idx = 0;
                foreach (var key in gcdDic.Keys)
                {

                    calc.Add(gcdDic[key]);
                }

                gcdDic.Clear();
                lcmDic.Clear();

                ret[0] = 1_000_000_000_000_000_000;
                ret[1] = 1;



                if (ret[0] > ret[1])
                {

                    sb.Append($"{lcm * ret[1]} {lcm * ret[0]}\n");
                }
                else
                {

                    sb.Append($"{lcm * ret[0]} {lcm * ret[1]}\n");
                }
            }

            using (StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())))
            {

                sw.Write(sb);
            }
        }


        static int ReadInt(StreamReader _sr)
        {

            int c, ret = 0;

            while ((c = _sr.Read()) != -1 && c != '\n' && c != ' ')
            {

                if (c == '\r') continue;

                ret = ret * 10 + c - '0';
            }

            return ret;
        }

        static long ReadLong(StreamReader _sr)
        {

            int c;
            long ret = 0;

            while((c = _sr.Read()) != -1 && c != '\n' && c != ' ')
            {

                if (c == '\r') continue;

                ret = ret * 10 + c - '0';
            }

            return ret;
        }
    }
}
