using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 3. 30
이름 : 배성훈
내용 : GCD 합
    문제번호 : 9613번

    수학, 정수론, 유클리드 호제법 문제다
    오버플로우로 한 번 틀렸다
    입력 숫자 범위는 100만이고, 개수는 100개까지 들어온다
    그래서 100만 * 5000개이므로, int 범위를 초월한다
    이후에는 GCD를 모두 합치니 이상없이 통과했다
*/

namespace BaekJoon.etc
{
    internal class etc_0397
    {

        static void Main397(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int test = ReadInt();
            int[] arr = new int[100];

            while(test-- > 0)
            {

                int len = ReadInt();

                for (int i = 0; i < len; i++)
                {

                    arr[i] = ReadInt();
                }

                long ret = 0;

                for (int i = 0; i < len - 1; i++)
                {

                    for (int j = i + 1; j < len; j++)
                    {

                        int gcd = GetGcd(arr[i], arr[j]);
                        ret += gcd;
                    }
                }

                sw.WriteLine(ret);
            }

            sr.Close();
            sw.Close();

            int GetGcd(int _a, int _b)
            {

                if (_a < _b)
                {

                    int temp = _a;
                    _a = _b;
                    _b = temp;
                }

                while(_b > 0)
                {

                    int temp = _a % _b;
                    _a = _b;
                    _b = temp;
                }

                return _a;
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
