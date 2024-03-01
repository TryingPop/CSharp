using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 3. 1
이름 : 배성훈
내용 : 수강변경
    문제번호 : 23305번

    풀이가 바로 안떠오른다;
*/

namespace BaekJoon.etc
{
    internal class etc_0136
    {

        static void Main136(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int len = ReadInt(sr);

            int[] man = new int[len];
            for (int i = 0; i < len; i++)
            {

                man[i] = ReadInt(sr);
            }
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
