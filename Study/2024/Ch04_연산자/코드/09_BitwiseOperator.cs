using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : 비트 연산자(논리 연산자)
    교재 p 136 ~ 139

    & : 두 피연산자의 비트 자리가 1인 경우 해당 비트 자리를 1을 채우고, 아니면 0을 채운다
    | : 두 피연산자의 비트 자리가 0인 경우 해당 비트 자리를 0을 채우고, 아니면 1을 채운다
    ^ : 두 피연산자의 비트 자리가 같은 경우 해당 비트 자리를 0로 채우고, 아니면 1을 채운다
    ~ : 피연산자의 비트 자리가 1인 경우 해당 비트자리를 0으로 바꾸고, 아니면 1로 바꾼다
*/

namespace Study._2024.Ch04
{
    internal class _09_BitwiseOperator
    {

        static void Main9(string[] args)
        {

            int a = 9;
            int b = 10;

            Console.WriteLine($"{a} & {b} : {a & b}");      // 8
            Console.WriteLine($"{a} | {b} : {a | b}");      // 11
            Console.WriteLine($"{a} ^ {b} : {a ^ b}");      // 3

            int c = 255;
            Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, ~c); // ~255(0x000000FF) : -256(0xFFFFFF00)
        }
    }
}
