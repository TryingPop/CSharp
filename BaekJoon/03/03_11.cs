using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.14
 * 내용 : 백준 3단계 11번 문제
 * 
 */

namespace BaekJoon._03
{
    internal class _03_11
    {
        static void Main11(string[] args)
        {
            string[] varArr1 = Console.ReadLine().Split(" ");
            string[] varArr2 = Console.ReadLine().Split(" ");
            int len = int.Parse(varArr1[0]);
            int x = int.Parse(varArr1[1]);

            int[] input = Array.ConvertAll(varArr2, int.Parse);

            foreach (int num in input)
            {
                if (num < x)
                {
                    Console.Write(num + " ");
                }
            }
            

        }
    }
}
