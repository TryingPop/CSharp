using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 21
이름 : 배성훈
내용 : IntegrerLiterals
    교재 p 50 ~ 51

    sbyte a = 50_000_000_000_000 을 넣으면 어떻게 될까 문제 있는데
    C#은 더 큰 자료형을 작은쪽에 넣는걸 허용하지 않기에 컴파일 에러가 발생한다
*/
namespace Study._2024.Ch03
{
    internal class _02_IntegerLiterals
    {

        static void Main2(string[] args)
        {

            byte a = 240;
            Console.WriteLine($"a = {a}");      // 240

            byte b = 0b1111_0000;
            Console.WriteLine($"b = {b}");      // 240

            byte c = 0XF0;
            Console.WriteLine($"c = {c}");      // 240

            uint d = 0x1234_abcd;
            Console.WriteLine($"d = {d}");      // 305441741
        }
    }
}
