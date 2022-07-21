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
        static void Main5(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            SelfFunc(num);

        }

        // 타입이 불분명한건 그냥 void 하고 return; 하면 된다
        static void SelfFunc(int n, int m = 0)
        {

        }

        static int FindNum(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return 2 * FindNum(n - 1) + 1;
        }
    }
}
