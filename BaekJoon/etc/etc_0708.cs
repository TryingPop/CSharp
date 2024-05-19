using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 5. -
이름 : 배성훈
내용 : N과 M
    문제번호 : 16214번
*/

namespace BaekJoon.etc
{
    internal class etc_0708
    {

        static void Main708(string[] args)
        {

            string ZERO = "0\n";
            string ONE = "1\n";

            StreamReader sr;
            StreamWriter sw;

            int n, m;

            List<int> div = new();

            void Solve()
            {

                Init();

                int test = ReadInt();

                while(test-- > 0)
                {

                    n = ReadInt();
                    m = ReadInt();

                    if (m == 1) 
                    { 
                        
                        sw.Write(ZERO);
                        continue;
                    }
                    else if (n == 1)
                    {

                        sw.Write(ONE);
                        continue;
                    }


                }
            }

            int GetPhi(int _n)
            {

                int ret = 1;
                for (int i = 2; i <= _n; i++)
                {

                    if (i * i > _n) break;
                    if (_n % i != 0) continue;

                    ret *= i - 1;
                    _n /= i;
                    while(_n % i == 0)
                    {

                        ret *= i;
                        _n /= i;
                    }
                }

                if (_n > 1) ret *= _n - 1;
                return ret;
            }

            long GetPow(long _a, long _b, long _mod)
            {

                long ret = 1;
                while(_b > 0)
                {

                    if ((_b & 1L) == 1L) ret = (ret * _a) % _mod;

                    _a = (_a * _a) % _mod;
                    _b /= 2;
                }

                return ret;
            }

            long GetGCD(long _a, long _b)
            {

                while(_b > 0)
                {

                    long temp = _a % _b;
                    _a = _b;
                    _b = temp;
                }

                return _a;
            }


            void Init()
            {

                sr = new(Console.OpenStandardInput(), bufferSize: 65536);
                sw = new(Console.OpenStandardOutput(), bufferSize: 65536);

                div = new(64);
            }

            int ReadInt()
            {

                int c, ret = 0;
                while((c =sr.Read()) != -1 && c != ' ' && c != '\n')
                {

                    if (c == '\r') continue;
                    ret = ret * 10 + c - '0';
                }

                return ret;
            }
        }
    }
}
