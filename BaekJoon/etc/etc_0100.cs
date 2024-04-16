using System;
using System.Collections.Generic;
using System.Linq;
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

    4%에서 시간초과다


    해당 아이디어를 참고해서 해봐야겠다
    https://ji-gwang.tistory.com/369

    힌트가 있었다.
    https://www.acmicpc.net/category/detail/3519
    보고 조만간 다시 해봐야겠다!
*/

namespace BaekJoon.etc
{
    internal class etc_0100
    {

        static void Main100(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int test = ReadInt();
            StringBuilder sb = new StringBuilder(20 * test);
            Dictionary<long, long> lcmDic = new Dictionary<long, long>(20);
            Dictionary<long, long> gcdDic = new Dictionary<long, long>(20);
            long[] calc = new long[20];
            long[] ret = new long[2];

            List<long> left = new(1 << 8);
            List<long> right = new(1 << 8);

            while (test-- > 0)
            {

                int len = ReadInt();

                long lcm = 1;
                for (int i = 0; i < len; i++)
                {

                    long cur = ReadLong();
                    lcm *= cur;

                    if (lcmDic.ContainsKey(cur)) lcmDic[cur] *= cur;
                    else lcmDic[cur] = cur;
                }

                len = ReadInt();
                for (int i = 0; i < len; i++)
                {

                    long cur = ReadLong();

                    if (gcdDic.ContainsKey(cur)) gcdDic[cur] *= cur;
                    else gcdDic[cur] = cur;
                }

                foreach (var key in lcmDic.Keys)
                {

                    gcdDic[key] /= lcmDic[key];
                }

                int idx = 0;
                foreach (var key in gcdDic.Keys)
                {

                    calc[idx++] = gcdDic[key];
                }

                gcdDic.Clear();
                lcmDic.Clear();

                Array.Sort(calc, 0, idx);

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

            int ReadInt()
            {

                int c, ret = 0;

                while ((c = sr.Read()) != -1 && c != '\n' && c != ' ')
                {

                    if (c == '\r') continue;

                    ret = ret * 10 + c - '0';
                }

                return ret;
            }
            long ReadLong()
            {

                int c;
                long ret = 0;

                while ((c = sr.Read()) != -1 && c != '\n' && c != ' ')
                {

                    if (c == '\r') continue;

                    ret = ret * 10 + c - '0';
                }

                return ret;
            }
        }
    }
}
