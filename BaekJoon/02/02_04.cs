using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.14
 * 내용 : 백준 2단계 4번 문제
 * 
 */

namespace BaekJoon._02
{
    internal class _02_04
    {
        static void Main4(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine("4");
                }
            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine("2");
                }
                else
                {
                    Console.WriteLine("3");
                }
            }
        }
    }
}
