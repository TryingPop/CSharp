using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 5
이름 : 배성훈
내용 : async 한정자와 await 연산자로 만드는 비동기 코드
    교재 p 690 ~ 693

    async 한정자와 await 연산자는 C# 5.0에서 새롭게 도입된 장치다.
    C# 5.0이전에는 BeginInvoke, EndInvoke로 비동기 코드 패턴을 지원했다.

    async 한정자로 메소드나 태스크를 수식하기만 하면 비동기 코드가 만들어진다.
    async로 한정하는 메소드는 반환형식이 Task나 Task<TResult> 또는 void 형식이어야 한다.
    실행하고 잊어버릴 (Shoot and Forget) 작업을 담고 잇는 메소드라면 반환형식을 void로 선언하고
    작업이 완료될떄까지 기다려야할 코드라면 Task, Task<TResult>로 선언하면 된다.

    C# 컴파일러는 Task 또는 Task<TResult> 형식의 메소드를 async 한정자가 수식하는 경우 await 연산자가 해당 메소드 어디에 있는지 찾는다.
    그리고 해당 await 연산자를 찾으면 그곳에서 호출자에게 제어를 돌려주도록 실행파일을 만든다.

    아래 예제에서 Task 안에 async await을 없애면
        A
        B
        C
        D
        E
        F
        C
        D
        0 / 3 ...
        1 / 3 ...
        2 / 3 ...
        G
        H
        0 / 5 ...
        1 / 5 ...
        2 / 5 ...
        3 / 5 ...
        4 / 5 ...
        G
        H

    다음처럼 출력된다.
*/

namespace Study._2024.Ch19_스레드와_태스크.코드
{
    internal class _11_Async
    {

        async static private void MyMethodAsync(int count)
        {

            Console.WriteLine("C");
            Console.WriteLine("D");

            // Task 안의 람다식에도 async, await이 있다.
            // 이는 await을 만나면 
            await Task.Run(async () =>
            {

                for (int i = 0; i < count; i++)
                {

                    Console.WriteLine($"{i} / {count} ...");
                    // Task.Delay는 인수로 입력 받은 시간이 지나면 Task 객체를 반환하는 것이다.
                    await Task.Delay(100);
                }
            });

            Console.WriteLine("G");
            Console.WriteLine("H");
        }

        static void Caller()
        {

            Console.WriteLine("A");
            Console.WriteLine("B");

            MyMethodAsync(3);

            Console.WriteLine("E");
            Console.WriteLine("F");
        }

        static void Main11(string[] args)
        {

            // A
            // B
            // C
            // D
            // E
            // F
            // 0 / 3 ...
            // C
            // D
            // 0 / 5 ...
            // 1 / 3 ...
            // 1 / 5 ...
            // 2 / 5 ...
            // 2 / 3 ...
            // 3 / 5 ...
            // G
            // H
            // 4 / 5 ...
            // G
            // H 
            Caller();

            MyMethodAsync(5);

            Console.ReadLine();
        }
    }
}
