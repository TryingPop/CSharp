using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 8
이름 : 배성훈
내용 : 대리자
    교재 p 457 ~ 460

    콜백은 메모처럼 어떤 일을 수행하는 코드,
    즉 콜백을 작성하고 다른 코드에 이 콜백을 맡겨 대신 실행하게 한다.

    C#에서는 콜백을 맡아 실행하는 일을 대리자가 담당한다.
    대리자(Delegate)는 대릴인 또는 사절이라고 볼 수 있다.

    콜백은 대리자를 선언하고, 대리자의 인스턴트를 생성한 뒤 인스턴트를 생성할 때 대리자가 참조할 메소드를 인수로 넘긴다.
    그리고 대리자를 호출하면 참조할 메소드가 실행된다.
*/

namespace Study._2024.Ch13_대리자와_이벤트.코드
{
    internal class _01_Delegate
    {

        delegate int MyDelegate(int a, int b);

        class Calculator
        {

            public int Plus(int a, int b)
            {

                return a + b;
            }

            public static int Minus(int a, int b)
            {

                return a - b;
            }
        }

        static void Main1(string[] args)
        {

            Calculator Calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));      // 7

            Callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Callback(7, 5));      // 2
        }
    }
}
