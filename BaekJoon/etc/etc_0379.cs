using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 3. -
이름 : 배성훈
내용 : 피보나치 수 4
    문제번호 : 10826번
    
    91부터 long 범위 초과한다
    FFT 알고리즘이 필요하다
*/

namespace BaekJoon.etc
{
    internal class etc_0379
    {

        static void Main379(string[] args)
        {

            long[] fibo = new long[10_001];
            fibo[0] = 1;
            fibo[1] = 1;
            for (int i = 2; i < fibo.Length; i++)
            {

                fibo[i] = fibo[i - 2] + fibo[i - 1];
            }

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(fibo[n]);
        }
    }
}
