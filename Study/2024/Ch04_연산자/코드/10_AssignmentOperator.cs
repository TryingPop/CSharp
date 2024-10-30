using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : 할당 연산자
    교재 p 139 ~ 141

    = : 오른쪽 피연산자를 왼쪾 피연산자에 할당합니다.
    '연산자'= ; a '연산자'= b는 a = a '연산자' b와 같다
   연산자에는 +, -, *, /, %, &, |, ^, <<, >>가 있다
*/

namespace Study._2024.Ch04
{
    internal class _10_AssignmentOperator
    {

        static void Main10(string[] args)
        {

            int a;
            a = 100;
            Console.WriteLine($"a = 100 : {a}");    // 100
            a += 90;
            Console.WriteLine($"a += 90 : {a}");    // 190
            a -= 80;
            Console.WriteLine($"a -= 80 : {a}");    // 110
            a *= 70;
            Console.WriteLine($"a *= 70 : {a}");    // 7700
            a /= 60;
            Console.WriteLine($"a /= 60 : {a}");    // 128
            a %= 50;
            Console.WriteLine($"a %= 50 : {a}");    // 28
            a &= 40;
            Console.WriteLine($"a &= 40 : {a}");    // 8
            a |= 30;
            Console.WriteLine($"a |= 30 : {a}");    // 30
            a ^= 20;
            Console.WriteLine($"a ^= 20 : {a}");    // 10
            a <<= 10;
            Console.WriteLine($"a <<= 10 : {a}");   // 10240
            a >>= 1;
            Console.WriteLine($"a >>= 1 : {a}");    // 5120
        }
    }
}
