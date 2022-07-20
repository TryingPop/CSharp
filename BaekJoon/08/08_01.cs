using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.20
 * 내용 : 백준 8단계 1번 문제
 * 
 */

namespace BaekJoon._08
{
    internal class _08_01
    {
        static void Main1(string[] args)
        {
            int result = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(" ");
            int[] intarr = Array.ConvertAll(inputs, int.Parse);
            int n = 2;
            foreach (int num in intarr)
            {
                if (num == 1)
                {
                    result--;
                }
                n = 2;
                while(num >= (n * n))
                {
                    if (num%n == 0)
                    {
                        result--;
                        break;
                    }
                    n++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
