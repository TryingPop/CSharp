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
