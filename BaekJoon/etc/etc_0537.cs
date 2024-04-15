using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. 15
이름 : 배성훈
내용 : 미로에 갇힌 상근
    문제번호 : 5069번
*/

namespace BaekJoon.etc
{
    internal class etc_0537
    {

        static void Main(string[] args)
        {

            StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int[] ret = new int[15];

            Solve();

            sr.Close();
            sw.Close();

            void Solve()
            {

                ret[0] = 1;
                for (int i = 1; i < 15; i++)
                {

                    for (int j = 1; j < 16; j++)
                    {


                    }
                }

                int test = ReadInt();
                while(test-- > 0)
                {

                    int n = ReadInt();
                    sw.WriteLine(ret[n]);
                }
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
