using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 4. 20
이름 : 배성훈
내용 : 세계 일주
    문제번호 : 31219번
*/

namespace BaekJoon.etc
{
    internal class etc_0578
    {

        static void Main578(string[] args)
        {

            StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));


            void Solve()
            {


            }


            int ReadInt()
            {

                int c, ret = 0;
                bool plus = true;
                while((c = sr.Read()) != -1 && c != ' ' && c != '\n')
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
