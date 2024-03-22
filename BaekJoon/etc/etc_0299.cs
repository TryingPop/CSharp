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

    문제가 많이 더럽다
    입력에서 4개씩 안들어오는 경우가 있다
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

            int[] left = new int[13];
            int[] right = new int[13];
            for (int i = 0; i < 3; i++)
            {

                int[] temp = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);


                int l = 0;
                int r = 0;

                int op = 0;
                int opIdx = 0;
                for (int j = 0; j < temp.Length; j++)
                {

                    if (temp[j] == '>' || temp[j] == '<' || temp[j] == '=')
                    {

                        l = j - 1;
                        r = j + 1;
                        op = temp[j] - '0';
                        opIdx = j;
                        break;
                    }
                }

                int lidx = 0;
                for (int j = 0; j < opIdx; j++)
                {

                    left[j] = temp[j];
                    lidx++;
                }

                int ridx = 0;
                for (int j = r; j < temp.Length; j++)
                {

                    right[j - r] = temp[j];
                    ridx++;
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

                    if (calc[i][j] != 0) continue;
                    calc[i][j] = isTrue ? 4 : 1;
                }
            }

            int ret = 0;
            int cnt = 0;
            bool isUp = true;
            for (int i = 1; i < 13; i++)
            {

                int b0 = calc[0][i];
                int b1 = calc[1][i];
                int b2 = calc[2][i];

                if (b0 == 1 || b1 == 1 || b2 == 1)
                {

                    calc[0][i] = 1;
                    calc[1][i] = 1;
                    calc[2][i] = 1;
                    cnt++;
                }
                else if ((b0 == 2 && b1 == 3) || (b1 == 2 && b2 == 3) || (b2 == 2 && b0 == 3)
                    || (b0 == 3 && b1 == 2) || (b1 == 3 && b2 == 2) || (b2 == 3 && b0 == 2))
                {

                    calc[0][i] = 1;
                    calc[1][i] = 1;
                    calc[2][i] = 1;
                    cnt++;
                } 

                if (b0 == 4 && b1 == 4 && b2 != 4)
                {

                    b0 = b2;
                    b1 = b2;
                }
                else if (b1 == 4 && b2 == 4 && b0 != 4)
                {

                    b1 = b0;
                    b2 = b0;
                }
                else if (b2 == 4 && b0 == 4 && b1 != 4)
                {

                    b2 = b1;
                    b0 = b1;
                }
                else if (b0 == 4 && b1 == b2 && b1 != 4)
                {

                    b0 = b1;
                }
                else if (b1 == 4 && b2 == b0 && b2 != 4)
                {

                    b1 = b2;
                }
                else if (b2 == 4 && b0 == b1 && b0 != 4)
                {

                    b2 = b0;
                }

                if (b0 == b1 && b1 == b2 && b1 != 4)
                {

                    if (ret != 0) ret = -1;
                    else ret = i;

                    if (b1 == 3) isUp = true;
                    else isUp = false;
                }
            }

            if (cnt == 12) Console.WriteLine("impossible");
            else if (ret == -1) Console.WriteLine("indefinite");
            else 
            { 
                
                Console.Write($"{ret}");
                if (isUp) Console.Write('+');
                else Console.Write('-');
            }
        }

        static int ReadInt(StreamReader _sr)
        {

            int c, ret = 0;
            bool eof = false;
            while((c = _sr.Read()) != -1 && c != ' ')
            {

                if (c == '\r') continue;
                else if (c == '\n')
                {

                    eof = true;
                    break;
                }
                ret = ret * 10 + c - '0';
            }


            if (eof && ret == 0) return -1;
            return ret;
        }
    }
}
