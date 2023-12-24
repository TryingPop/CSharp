using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 12. 25
이름 : 배성훈
내용 : 오아시스 재결합
    문제번호 : 3015번

    먼저 삼중 포문으로 만들어 풀어보자!
    O(Nlog N)으로 줄여야한다
*/

namespace BaekJoon._31
{
    internal class _31_05
    {

        static void Main5(string[] args)
        {

            int[] heights;
            using (StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput())))
            {

                int len = int.Parse(sr.ReadLine());

                heights = new int[len]; 
                for (int i = 0; i < len; i++)
                {

                    heights[i] = int.Parse(sr.ReadLine());
                }
            }

            int result = 0;

            // Wrong!
            for (int term = 1; term < heights.Length - 1; term++)
            {

                for (int start = 0; start + term < heights.Length; start++)
                {

                    int end = start + term;

                    result++;
                    for (int chk = 1; chk < term; chk++)
                    {

                        if (heights[start + chk] > heights[start]
                            || heights[start + chk] > heights[end])
                        {

                            result--;
                            break;
                        }

                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
