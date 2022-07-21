using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.21
 * 내용 : 백준 9단계 2번 문제
 * 
 */

namespace BaekJoon._09
{
    internal class _09_02
    {
        static void Main2(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            long result = 1;
            for (int i = 2;i <= num; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
