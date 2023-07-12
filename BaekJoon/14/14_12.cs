using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2023. 7. 12
이름 : 배성훈
내용 : 가장 긴 증가하는 부분 수열
    문제번호 : 11053번
*/

namespace BaekJoon._14
{
    internal class _14_12
    {

        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), item => int.Parse(item));

            int[] lens = new int[length];
            int[] maxs = new int[length];

            for (int i = 0; i < length; i++)
            {

                if (i == 0)
                {

                    lens[i] = 1;
                    maxs[i] = nums[0];
                    continue;
                }

            }
        }
    }
}
