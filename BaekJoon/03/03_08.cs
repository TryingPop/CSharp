using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.14
 * 내용 : 백준 3단계 8번 문제
 * 
 */

namespace BaekJoon._03
{
    internal class _03_08
    {
        static void Main8(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            int a;
            int b;

            for (int i = 0; i < len; i++)
            {
                string[] s = Console.ReadLine().Split(" ");
                a = int.Parse(s[0]);
                b = int.Parse(s[1]);
                Console.WriteLine("Case #{0}: {1}", i, a + b);
            }
        }
    }
}
