using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.20
 * 내용 : 백준 8단계 2번 문제
 * 
 */

namespace BaekJoon._08
{
    internal class _08_02
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            

            int result1 = 0;
            int result2 = 1000000;

            bool chk = true;

            for (int i = min; i <= max; i++)
            {
                int n = ((int)Math.Sqrt(i)) + 1;
                
                for (int j = 1; j <= n; j++)
                {
                    if (i % j == 0)
                    {
                        chk = false;
                        break;
                    }
                }
                
                if (chk)
                {
                    result1 += i;
                    if (result2 >= i)
                    {
                        result2 = i;
                    }
                }
            }
            if (result1 == 0)
            {

            }
        }
    }
}
