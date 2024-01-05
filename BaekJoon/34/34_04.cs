using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 1. 5
이름 : 배성훈
내용 : 소수의 연속합
    문제번호 : 1644번
*/

namespace BaekJoon._34
{
    internal class _34_04
    {

        static void Main4(string[] args)
        {

            
            int MAX = int.Parse(Console.ReadLine());

            bool[] notPrimes = new bool[MAX + 1];

            int len = (int)Math.Sqrt(MAX) + 1;
            for (int i = 2; i < len; i++)
            {

                if (notPrimes[i]) continue;

                bool chk = false;
                for (int j = 2; j <= MAX; j++)
                {


                    if (i * j > MAX) break;

                    if (notPrimes[i * j]) continue;

                    notPrimes[i * j] = true;
                }
            }


            Console.WriteLine();
        }
    }
}
