using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
날짜 : 2024. 2. 10
이름 : 배성훈
내용 : 큰 수 곱셈
    문제번호 : 13277번

    시간 초과 뜬다
    고속 푸리에변환 알고리즘을 써야 해결된다고 한다

    문자열 길이가 30만이므로,
    5만 * 5만? 25억 이다;

    당장은 파이썬은 큰 수의 곱셈을 지원하기에 파이썬으로 그냥 풀었다

    ///////////////////////////////////////////////////////////////
    # 파이썬 코드 #은 <- 파이썬에서 사용하는 주석이다

        a, b = map(int, input().split())
        ret = a * b
        print(ret)
    ///////////////////////////////////////////////////////////////
    시간은 5.2초 나왔다

    어차피 고속 푸리에변환은 2달 안으로 만날거 같으니 그때가서 C++로 풀어야겠다

*/

namespace BaekJoon.etc
{
    internal class etc_0010
    {

        static void Main10(string[] args)
        {

#if WrongTimeOut
            // 시간 초과나는 방법이다
            // 입력
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StringBuilder sb = new StringBuilder(300_000);

            ReadStr(sr, sb);
            string str1 = sb.ToString();
            sb.Clear();

            ReadStr(sr, sb);
            string str2 = sb.ToString();
            sb.Clear();
            sr.Close();
            // 연산
            int len1 = str1.Length;
            int len2 = str2.Length;

            len2 = 1 + len2 / 7;
            len1 = 1 + len1 / 7;
            long[] result = new long[len1 + len2 + 3];
            long MAX = 10_000_000;

            for (int i = 0; i < len2; i++)
            {

                long num2 = ReadLong(str2, i);

                for (int j = 0; j < len1; j++)
                {

                    long num1 = ReadLong(str1, j);
                    
                    long mul = num1 * num2;
                    long fir = mul % MAX;
                    long sec = mul / MAX;

                    result[j + i] += fir;
                    result[j + i + 1] += sec;

                    while (result[j + i] >= MAX)
                    {

                        result[j + i] -= MAX;
                        result[j + i + 1] += 1;
                    }

                    while (result[j + i + 1] >= MAX)
                    {

                        result[j + i + 1] -= MAX;
                        result[j + i + 2] += 1;
                    }
                }
            }

            bool start = false;
            for (int i = result.Length - 1; i >= 0; i--)
            {

                if (!start) 
                {

                    if (result[i] != 0)
                    {

                        sb.Append(result[i]);
                        start = true;
                    }
                    continue;
                }

                sb.Append($"{result[i]:D7}");
            }

            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            sw.Write(sb);
            sw.Close();

#endif
        }

        static void ReadStr(StreamReader _sr, StringBuilder _sb)
        {

            int c;
            while((c = _sr.Read()) != '\n' && c != ' ' && c != -1)
            {

                if (c == '\r') continue;

                _sb.Append((c - '0'));
            }
        }

        static long ReadLong(string _str, int _n)
        {

            int end = (_str.Length) - _n * 7;
            int start = Math.Max(end - 7, 0);

            long ret = 0;
            for (int i = start; i < end; i++)
            {

                ret *= 10;
                ret += _str[i] - '0';
            }

            return ret;
        }
    }
}
