using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : 논리 연산자
    교재 p 125 ~ 127

    && : 양쪽 피연산자 모두 참일 때 참, 아니면 거짓
    || : 양쪽 피연산자 모두 거짓일 때 거짓, 아니면 참
    ! : 피연산자가 참이면 거짓, 아니면 참
*/

namespace Study._2024.Ch04
{
    internal class _05_LogicalOperator
    {

        static void Main5(string[] args)
        {

            Console.WriteLine("Testing && ...");
            Console.WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");        // True
            Console.WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");        // False
            Console.WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");      // False
            Console.WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");      // False

            Console.WriteLine("\nTesting || ...");
            Console.WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");        // True
            Console.WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");        // True
            Console.WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");      // False
            Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");      // True

            Console.WriteLine("\nTesting ! ...");
            Console.WriteLine($"!True : {!true}");                          // False
            Console.WriteLine($"!False: {!false}");                         // True
        }
    }
}
