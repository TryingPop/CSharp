using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. 22
이름 : 배성훈
내용 : 수학 공책
    문제번호 : 8973번
*/

namespace BaekJoon.etc
{
    internal class etc_0595
    {

        static void Main595(string[] args)
        {

            StreamReader sr;
            int n;
            int[] arr1;
            int[] arr2;

            void Solve()
            {

                Input();

            }

            void Input()
            {

                sr = new(new BufferedStream(Console.OpenStandardInput()));
                n = ReadInt();
                arr1 = new int[n];
                arr2 = new int[n];

                for (int i = 0; i < n; i++)
                {

                    arr1[i] = ReadInt();
                }

                for (int i = n - 1; i >= 0; i--)
                {

                    arr2[i] = ReadInt();
                }

                sr.Close();
            }
            int ReadInt()
            {

                int c, ret = 0;
                bool plus = true;
                while((c= sr.Read()) != -1 && c != ' ' && c != '\n') 
                {

                    if (c == '\r') continue;
                    else if (c == '-')
                    {

                        plus = false;
                        continue;
                    }

                    ret = ret * 10 + c - '0';
                }

                return plus ? ret : -ret;
            }
        }
    }
}
