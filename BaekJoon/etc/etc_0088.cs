using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 2. 24
이름 : 배성훈
내용 : 영재의 징검다리
    문제번호 : 24392번
*/

namespace BaekJoon.etc
{
    internal class etc_0088
    {

        static void Main88(string[] args)
        {


        }

        static int ReadInt(StreamReader _sr)
        {

            int ret = 0, c;

            while ((c = _sr.Read()) != -1 && c != '\n' && c != ' ')
            {

                if (c == '\r') continue;

                ret = ret * 10 + c - '0';
            }

            return ret;
        }
    }
}
