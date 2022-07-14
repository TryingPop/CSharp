using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.14
 * 내용 : 백준 1단계 11번 문제
 * 
 */

namespace BaekJoon._01
{
    internal class _01_11
    {
        static void Main11(string[] args)
        {
            int plus = 1998 - 2541;
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(year + plus);
        }
    }
}
