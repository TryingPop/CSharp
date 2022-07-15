using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.14
 * 내용 : 백준 3단계 2번 문제
 * 
 */


namespace BaekJoon._03
{
    internal class _03_02
    {
        static void Main2(string[] args)
        {
            while (true)
            {
                string[] strinputs = Console.ReadLine().Split(' ');
                int[] inputs = Array.ConvertAll(strinputs, int.Parse);

                Console.WriteLine(inputs[0] + inputs[1] - 3);
            }

        }
    }
}