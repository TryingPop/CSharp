using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 3. 8
이름 : 배성훈
내용 : 결혼식
    문제번호 : 5567번
*/

namespace BaekJoon.etc
{
    internal class etc_0164
    {

        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int n = ReadInt(sr);

            List<int>[] friends = new List<int>[n + 1];

            for (int i = 1; i <= n; i++)
            {

                friends[i] = new();
            }

            int len = ReadInt(sr);

            for (int i = 0; i < len; i++)
            {

                int f = ReadInt(sr);
                int b = ReadInt(sr);

                friends[f].Add(b);
                friends[b].Add(f);
            }

            sr.Close();

            Queue<int> q = new Queue<int>();
            bool[] accept = new bool[n + 1];

            accept[1] = true;

            for (int i = 0; i < friends[1].Count; i++)
            {
                
                q.Enqueue(friends[1][i]);
            }

            while (q.Count > 0)
            {

                var node = q.Dequeue();
                accept[node] = true;

                for (int i = 0; i < friends[node].Count; i++)
                {

                    int idx = friends[node][i];
                    accept[idx] = true;
                }
            }

            int ret = -1;
            for (int i = 1; i <= n; i++)
            {

                if (accept[i]) ret++;
            }

            Console.WriteLine(ret);
        }

        static int ReadInt(StreamReader _sr)
        {

            int c, ret = 0;

            while((c = _sr.Read()) != -1 && c != ' ' && c != '\n')
            {

                if (c == '\r') continue;
                ret = ret * 10 + c - '0';
            }

            return ret;
        }
    }
}
