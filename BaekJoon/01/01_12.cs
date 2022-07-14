using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.14
 * 내용 : 백준 1단계 12번 문제
 * 
 */

namespace BaekJoon._01
{
    internal class _01_12
    {
        static void Main12(string[] args)
        {
            string[] strinputs = Console.ReadLine().Split(' ');
            int[] intinputs = Array.ConvertAll(strinputs, int.Parse);

            int A = intinputs[0];
            int B = intinputs[1];
            int C = intinputs[2];

            Console.WriteLine((A + B) % C);
            Console.WriteLine(((A % C) + (B % C)) % C);
            Console.WriteLine((A*B) % C);
            Console.WriteLine(((A % C) * (B % C)) % C);
        }
    }
}
