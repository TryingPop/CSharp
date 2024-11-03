using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 3
이름 : 배성훈
내용 : 예외 던지기
    교재 p 436 ~ 440

    System.Exception 클래스는 모든 예외의 조상이다.
    C#에서 모든 예외 클래스는 반드시 이 클래스로부터 상속받아야 한다.
    IndexOutOfRangeException 예외도 System.Exception 으로부터 파생되었다.

    예외 처리는 System.Exception 하나로 대응하는건 어렵다.
    System.Exception은 프로그래머가 발생할 것으로 계산한 예외 말고도 다른 예외까지 받아낼 수 있기 때문이다.
    그래서 현재 코드가 아닌 상위 코드에서 처리해야할 예외라면, System.Exception에서 실행되는 예외는 버그를 만들어내고 있다.

    코드를 면밀히 검토해서 처리하지 않아야 할 예외까지 처리하는 일이 없도록 해야한다.

    C#에서 예외를 던지는 방법은 throw 문을 이용해서 던진다.
*/

namespace Study._2024.Ch12_예외.코드
{
    internal class _03_Throw
    {

        static void DoSomething(int arg)
        {

            if (arg < 10)
                Console.WriteLine($"arg: {arg}");
            else
                throw new Exception("arg가 10보다 큽니다.");
        }

        static void Main3(string[] args)
        {

            // 2 3 5 7
            // arg가 10보다 큽니다.
            try
            {

                DoSomething(2);
                DoSomething(3);
                DoSomething(5);
                DoSomething(7);
                DoSomething(11);
                DoSomething(13);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
