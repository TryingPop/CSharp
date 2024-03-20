using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 3. 20
이름 : 배성훈
내용 : 동전
    문제번호 : 3363번
*/

namespace BaekJoon.etc
{
    internal class etc_0299
    {

        static void Main299(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            bool[] chk = new bool[3];

            int[][] calc = new int[3][];
            for (int i = 0; i < 3; i++)
            {

                calc[i] = new int[13];
            }

            int[] left = new int[4];
            int[] right = new int[4];

            for (int i = 0; i < 3; i++)
            {

                int l = 0;
                int r = 0;
                for (int j = 0; j < 4; j++)
                {

                    int cur = ReadInt(sr);
                    left[j] = cur;
                    l += cur;
                }

                int op = ReadInt(sr);

                for (int j = 0; j < 4; j++)
                {

                    int cur = ReadInt(sr);
                    right[j] = cur;
                    r += cur;
                }

                bool isTrue = true;
                bool isL = true;
                if (op == '<' - '0') isTrue = false;
                else if (op == '>' - '0') 
                { 
                    
                    isTrue = false; 
                    isL = false; 
                }

                for (int j = 0; j < 4; j++)
                {

                    calc[i][left[j]] = isTrue ? 1 : isL ? 2 : 3;
                    calc[i][right[j]] = isTrue ? 1 : isL ? 3 : 2;
                }

                for (int j = 1; j < 13; j++)
                {

                }

            }

            Console.WriteLine();
        }

        static int ReadInt(StreamReader _sr)
        {

            int c, ret = 0;

            while((c = _sr.Read()) != -1 && c != ' ' && c != '\n')
            {

                if (c == '\r') continue;
                ret = ret * 10 + c - '0';
            }

            return ret;
        }
    }
}
