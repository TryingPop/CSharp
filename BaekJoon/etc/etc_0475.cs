using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. 7
이름 : 배성훈
내용 : BFFs (small)
    문제번호 : 14379번

    아이디어가 따로 안떠오른다
*/

namespace BaekJoon.etc
{
    internal class etc_0475
    {

        static void Main475(string[] args)
        {

            int[] bffs = new int[11];

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int test = ReadInt();
            while(test-- > 0)
            {

                int n = ReadInt();

                for (int i = 1; i <= n; i++)
                {

                    int cur = ReadInt();
                    bffs[i] = cur;
                }
            }


            int ReadInt()
            {

                int c, ret = 0;
                while((c = sr.Read()) != -1 && c!= ' ' && c != '\n')
                {

                    if (c == '\r') continue;
                    ret = ret * 10 + c - '0';
                }

                return ret;
            }
        }
    }
}
