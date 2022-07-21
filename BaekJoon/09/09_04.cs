using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.21
 * 내용 : 백준 9단계 4번 문제
 * 
 */

namespace BaekJoon._09
{
    internal class _09_04
    {
        static void Main4(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            SelfFunc(num);

        }

        // 타입이 불분명한건 그냥 void 하고 return; 하면 된다
        static void SelfFunc(int n, int m = 0)
        {
            if (n <= 1)
            {
                return;
            }

            SelfFunc(n / 3);
            
        }

        static void LemmaFunc1(int m)
        {
        }

        static void LemmaFunc2(int m)
        {
        }
    }
}
