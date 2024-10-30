using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : 비트 연산자(시프트 연산자)
    교재 p 131 ~ 135

    << : 첫 번째 피연산자의 비트를 두 번째 피연산자의 수만큼 왼쪽으로 이동한다
        빈 공간은 0으로 채운다 이동 횟수가 해당 비트 크기를 벗어나면 나머지 연산을 이용해 비트 크기로 맞춘 뒤 연산을 진행한다

    >> : 첫 번째 피연산자의 비트를 두 번재 피연산자의 수만큼 오른쪽으로 이동한다
        빈 공간은 부호 비트로 채운다 이동 횟수가 해당 비트 크기를 벗어나면 나머지 연산을 이용해 비트 크기로 맞춘 뒤 연산을 진행한다
*/

namespace Study._2024.Ch04
{
    internal class _08_ShiftOperator
    {

        static void Main8(string[] args)
        {

            Console.WriteLine("Testing << ...");

            int a = 1;
            Console.WriteLine("a      : {0:D5} (0x{0:X8})", a);        // 00001 (0x00000001)
            Console.WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 1);   // 00002 (0x00000002)
            Console.WriteLine("a << 2 : {0:D5} (0x{0:X8})", a << 2);   // 00004 (0x00000004)
            Console.WriteLine("a << 5 : {0:D5} (0x{0:X8})", a << 5);   // 00032 (0x00000020)

            Console.WriteLine("\nTesting >> ...");
            int b = 255;
            Console.WriteLine("b      : {0:D5} (0x{0:X8})", b);        // 00255 (0x000000FF)
            Console.WriteLine("b >> 1 : {0:D5} (0x{0:X8})", b >> 1);   // 00127 (0x0000007F)
            Console.WriteLine("b >> 2 : {0:D5} (0x{0:X8})", b >> 2);   // 00063 (0x0000003F)
            Console.WriteLine("b >> 5 : {0:D5} (0x{0:X8})", b >> 5);   // 00007 (0x00000007)

            Console.WriteLine("\nTesting >> 2 ...");
            int c = -255;
            Console.WriteLine("c      : {0:D5} (0x{0:X8})", c);        // -00255 (0xFFFFFF01)
            Console.WriteLine("c >> 1 : {0:D5} (0x{0:X8})", c >> 1);   // -00128 (0xFFFFFF80)
            Console.WriteLine("c >> 2 : {0:D5} (0x{0:X8})", c >> 2);   // -00064 (0xFFFFFFC0)
            Console.WriteLine("c >> 5 : {0:D5} (0x{0:X8})", c >> 5);   // -00008 (0xFFFFFFF8)
        }
    }
}
