using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. 1
이름 : 배성훈
내용 : 공장
    문제번호 : 7578번
*/

namespace BaekJoon.etc
{
    internal class etc_0428
    {

        static void Main428(string[] args)
        {

            StreamReader sr;
            int[] nTi;
            int len;

            int[] seg;

            Solve();

            void Solve()
            {

                Init();


            }

            void Init()
            {

                nTi = new int[1_000_001];
                Array.Fill(nTi, -1);

                sr = new(Console.OpenStandardInput(), bufferSize: 65536 * 16);
                len = ReadInt();

                int log = (int)Math.Ceiling(Math.Log2(len)) + 1;
                seg = new int[1 << log];

                for (int i = 0; i < len; i++)
                {

                    int n = ReadInt();
                    nTi[n] = i;
                }
            }

            int ReadInt()
            {

                int c, ret = 0;
                while((c = sr .Read()) != -1 && c != ' ' && c != '\n')
                {

                    if (c == '\r') continue;
                    ret = ret * 10 + c - '0';
                }

                return ret;
            }
        }
    }
}
