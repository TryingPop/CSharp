using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. -
이름 : 배성훈
내용 : 회의실 배정 4
    문제번호 : 19623번

    힌트 보니 이분 탐색이였다;
    이분 매칭이 아니다;
*/

namespace BaekJoon.etc
{
    internal class etc_0549
    {

        static void Main549(string[] args)
        {

            StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            int n = ReadInt();

            (int s, int e, int w)[] arr = new (int s, int e, int w)[n];

            void Solve()
            {

                
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
