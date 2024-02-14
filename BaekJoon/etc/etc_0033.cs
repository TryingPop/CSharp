using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 2. 14
이름 : 배성훈
내용 : 보석 구매하기
    문제번호 : 2313번

    Kadane's 알고리즘?
    https://shoark7.github.io/programming/algorithm/4-ways-to-get-subarray-consecutive-sum

    내일 한 번 해보자!
*/

namespace BaekJoon.etc
{
    internal class etc_0033
    {

        static void Main33(string[] args)
        {

            
        }

        static int ReadInt(StreamReader _sr)
        {

            int ret = 0;
            int c;
            bool minus = false;

            while((c = _sr.Read()) != -1 && c != '\n' && c != ' ')
            {

                if (c == '\r') continue;
                else if (c == '-')
                {

                    minus = true;
                    continue;
                }

                ret = ret * 10 + c - '0';
            }

            return ret;
        }
    }
}
