using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.03
 * 내용 : 피보나치 연습문제
 */

namespace Exam._08
{
    internal class _08_06
    {
        static void Main6(string[] args)
        {
            int index;
            int primes = 0;

            for(int i = 2; i < 1000; i++)
            {
                for (index = 2; index<i; index++)
                {
                    if (i % index == 0)
                    {
                        break;
                    }
                }


                if (index == i)
                {
                    primes++;
                    Console.Write("{0,5}{1}", i, primes%15 == 0? "\n" : "");
                }
            }
            Console.WriteLine("\n2부터 1000 사이의 소수의 갯수 : {0}개", primes);
        }
    }
}
