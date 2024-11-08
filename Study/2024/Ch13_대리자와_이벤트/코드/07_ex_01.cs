using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 8
이름 : 배성훈
내용 : 연습문제 1
    교재 p 482

    출력 결과가 다음과 같이 나오도록 다음 코드에 익명 메소드를 추가하여 완성하세요.

    출력 결과
        7
        2


    코드
        using System;

        delegate int MyDelegate(int a, int b);

        static void Main(string[] args)
        {

            MyDelegate Callback;

            Callback = // 익명 메소드 선언

            Console.WriteLine(Callback(3, 4));

            Callback = // 익명 메소드 선언

            Console.WriteLine(Callback(7, 5));
        }
*/

namespace Study._2024.Ch13_대리자와_이벤트.코드
{
    internal class _07_ex_01
    {

        delegate int MyDelegate(int a, int b);

        static void Main7(string[] args)
        {

            MyDelegate Callback;

            Callback = delegate (int a, int b) { return a + b; };

            Console.WriteLine(Callback(3, 4));

            Callback = delegate (int a, int b) { return a - b; };

            Console.WriteLine(Callback(7, 5));
        }
    }
}
