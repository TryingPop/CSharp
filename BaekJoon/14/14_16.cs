using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 13
이름 : 배성훈
내용 : 평범한 배낭
    문제번호 : 12865번
*/
namespace BaekJoon._14
{

    internal class _14_16
    {

        static void Main16(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int[] info = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

            int[][] inputs = new int[info[0]][];

            for (int i =0;i < info[0]; i++)
            {

                inputs[i] = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            }

            int[] memo = new int[info[0]];

            for (int i = 0; i < info[0]; i++)
            {

                int weight = info[1];
                for (int j = i; j < info[0]; j++)
                {

                    if (weight - inputs[j][0] >= 0)
                    {

                        
                    }
                }
            }
        }
    }
}
