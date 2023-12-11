using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 12. 11
이름 : 배성훈
내용 : 히스토그램에서 가장 큰 직사각형
    문제번호 : 6549번
*/

namespace BaekJoon._27
{
    internal class _27_09
    {

        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();

            using (StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
            {

                while (true)
                {

                    int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                    if (inputs[0] == 0) break;

                    int[] lens = new int[inputs.Length];
                    bool[] chk = new bool[inputs.Length];
                    // 사각형 가로 길이 연산
                    // O(n^2) 시간을 쓴다 시간초과 떴다
                    // 다른 방법으로 해야한다!
                    for (int i = 1; i <= inputs[0]; i++)
                    {

                        for (int j = 1; j <= i; j++)
                        {

                            if (!chk[j])
                            {

                                if (inputs[i] >= inputs[j])
                                {

                                    lens[j]++;
                                }
                                else
                                {

                                    chk[j] = true;
                                }
                            }
                        }
                    }


                    long result = -1;
                    for (int i = 1; i <= inputs[0]; i++)
                    {

                        long squareArea = inputs[i] * lens[i];
                        if (result < squareArea) result = squareArea;
                    }

                    sb.AppendLine(result.ToString());
                }
            }

            using (StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())))
            {

                sw.Write(sb);
            }
                
        }
    }
}
