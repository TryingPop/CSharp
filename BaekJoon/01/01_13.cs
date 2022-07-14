using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.14
 * 내용 : 백준 1단계 13번 문제
 * 
 */

namespace BaekJoon._01
{
    internal class _01_13
    {
        static void Main13(string[] args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();

            for (int i = B.Length; i >= 1; i--)
                Console.WriteLine(int.Parse(A) * int.Parse(B[i-1].ToString()));

            Console.WriteLine(int.Parse(A)*int.Parse(B));
            
        }
    }
}
