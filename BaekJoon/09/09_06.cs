using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.21
 * 내용 : 백준 9단계 5번 문제
 * 
 */

namespace BaekJoon._09
{
    internal class _09_06
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int len = FindNum(num);
            
            sb.AppendLine(len.ToString());


            Console.WriteLine(sb);
            
        }

        // 타입이 불분명한건 그냥 void 하고 return; 하면 된다
        static int FindNum(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return 2 * FindNum(n - 1) + 1;
        }

        static void Left(int n, ref int[] m)
        {
            int len = m.Length;
            for (int i = n; i >= 0; i--)
            {
                
            }
        }
    }
}
