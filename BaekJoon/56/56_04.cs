using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 6. 22
이름 : 배성훈
내용 : 반복 패턴
    문제번호 : 166229번

    문자열, z알고리즘이다
    z알고리즘을 제대로 이해 못해서 이상하게 계속 틀렸따
*/

namespace BaekJoon._56
{
    internal class _56_04
    {

        static void Main(string[] args)
        {

            int n, k;
            int[] zArr;
            int[] str;

            Solve();

            void Solve()
            {

                Input();

                int ret = GetRet();

                Console.Write(ret);
            }

            int GetRet()
            {

                zArr = Z();

                if (k >= n) return n;
                int max = n + k;
                int ret = 0;

                for (int i = 1; i < zArr.Length; i++)
                {

                    if (n - i != zArr[i]) continue;
                    int chk = i * ((n - 1) / i) + i;
                    if (max < chk) continue;

                    if (ret < i) ret = i;
                }

                return ret;
            }

            void Input()
            {

                StreamReader sr = new(Console.OpenStandardInput(), bufferSize: 65536 * 4);
                string[] temp = sr.ReadLine().Split();

                n = int.Parse(temp[0]);
                k = int.Parse(temp[1]);

                string chk = sr.ReadLine().Trim();
                str = new int[n];

                for (int i = 0; i < n; i++)
                {

                    str[i] = chk[i];
                }

                sr.Close();
            }

            int[] Z()
            {

                int[] arr = new int[n];

                int l = 0;
                int r = 0;

                arr[0] = n;
                for (int i = 1; i < n; i++)
                {

                    if (i <= r) arr[i] = Math.Min(r - i, arr[i - l]);

                    while (i + arr[i] < n && str[i + arr[i]] == str[arr[i]])
                    {

                        arr[i]++;
                    }

                    if (i > r) l = i;
                    r = Math.Max(r, i + arr[i] - 1);
                }

                return arr;
            }
        }
    }
}
