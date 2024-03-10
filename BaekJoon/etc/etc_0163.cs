using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 3. 8
이름 : 배성훈
내용 : 카르텔 님 게임
    문제번호 : 30688번
*/

namespace BaekJoon.etc
{
    internal class etc_0163
    {

        static void Main163(string[] args)
        {

            StreamReader sr = new(Console.OpenStandardInput());

            int N = ReadInt(sr);
            // 짝수 고정
            int K = ReadInt(sr);

            sr.Close();

            // 승리 전략을 다시 짜봐야한다
            // 음... K = 10으로 하는데, 30부터 잘 안넘어간다;
            // 1 ~ 10 -> A, B
            // 11 ~ 12 -> C
            // 13 ~ 21 -> A, B
            // 22 ~ 25 -> C
            // 26 ~ 

            bool[] dp = new bool[N + 1];
            for (int i = 1; i <= K; i++)
            {

                dp[i] = true;
            }

            for(int i = K + 3; i <= 2 * K + 1; i++)
            {

                dp[i] = true;
            }



            Console.WriteLine();
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
