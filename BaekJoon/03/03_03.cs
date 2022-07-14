using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.14
 * 내용 : 백준 3단계 3번 문제
 * 
 */

namespace BaekJoon._03
{
    internal class _03_03
    {
        static void Main3(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= inputs; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
        }
    }
}
