using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.21
 * 내용 : 백준 10단계 3번 문제
 * 
 */

namespace BaekJoon._10
{
    internal class _10_03
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] result = new int[num];
            int[,] uarr = new int[num, 2];

            for (int i = 0; i < num; i++)
            {
                string[] strarr = Console.ReadLine().Split(" ");
                int[] iarr = Array.ConvertAll(strarr, int.Parse);

                uarr[i, 0] = iarr[0];
                uarr[i, 1] = iarr[1];


            }
        }
    }
}
