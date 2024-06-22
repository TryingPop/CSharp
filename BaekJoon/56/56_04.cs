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

    현재 계속해서 틀린다;
*/

namespace BaekJoon._56
{
    internal class _56_04
    {

        static void Main4(string[] args)
        {

            int n, k;
            int[] zArr;
            int[] str;

            Solve();

            void Solve()
            {

                Input();

                zArr = Z();

                int max = n + k;
                int ret = max >= 2 * n ? n : 0;

                for (int i = 1; i < zArr.Length; i++)
                {

                    int len = n - zArr[i];
                    if (len == n || max < 2 * len) continue;
                    if (ret < len) ret = len;
                }

                Console.Write(ret);
            }

            void Input()
            {

                StreamReader sr = new(Console.OpenStandardInput(), bufferSize: 65536 * 4);
                string[] temp = sr.ReadLine().Split();

                n = int.Parse(temp[0]);
                k = int.Parse(temp[1]);

                str = new int[n];

                for (int i = n - 1; i >= 0; i--)
                {

                    str[i] = sr.Read();
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
