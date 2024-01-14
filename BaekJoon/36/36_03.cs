using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 1. 14
이름 : 배성훈
내용 : 트리의 지름
    문제번호 : 1967번
*/

namespace BaekJoon._36
{
    internal class _36_03
    {

        static void Main3(string[] args)
        {

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

            int len = int.Parse(sr.ReadLine());

            List<(int dst, int dis)>[] root = new List<(int dst, int dis)>[len + 1];

            for (int i = 0; i < len; i++)
            {

                root[i] = new();
            }

            for (int i = 0; i < len - 1; i++)
            {

                int[] temp = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);

                root[temp[0]].Add((temp[1], temp[2]));
                root[temp[1]].Add((temp[0], temp[2]));
            }

            sr.Close();


        }
    }
}
