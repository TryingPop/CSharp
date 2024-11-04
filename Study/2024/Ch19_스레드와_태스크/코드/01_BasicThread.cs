using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 4
이름 : 배성훈
내용 : 
    교재 p641 ~ 647

    오늘날 운영체제는 여러 프로세스(Process)를
    동시에 실행할 수 잇는 능력을 갖추고 있다.

    프로세스는 실행파일이 적재된 인스턴스다.
    프로세스는 반드시 하나 이상의 스레드(Thread)로 구성된다.

    스레드는 운영체제 CPU 시간을 할당하는 기본 단위이다.
    스레드를 이용하면 응답성을 높일 수 있다.

    멀티 프로세스 방식에 비해 멀티 스레드 방식이 자원공유가 쉽다.
    멀티 프로세스는 IPC를 이용해야 한다.

    그리고 프로세스는 메모리와 자원을 할당하는 작업이 있어 비싸지만 
    스레드는 메모리와 자원을 그대로 사용해 경제성이 좋다.

    멀티 스레드 구조의 소프트웨어는 구현하기가 매우 까다롭다.
    스레드 중 하나에 문제가 생기면 프로세스 전체에 이상을 준다.
    스레드를 너무 많이 사용하면 작업간 전환(Context Switching)으로 오히려 성능저하가 일어난다.
*/

namespace Study._2024.Ch19_스레드와_태스크.코드
{
    internal class _01_BasicThread
    {

        static void DoSomething()
        {

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"DoSomething: {i}");
                Thread.Sleep(10);
            }
        }

        static void Main1(string[] args)
        {

            
            Thread t1 = new Thread(new ThreadStart(DoSomething));

            // 실행 따라 다르다
            // Starting thread...
            // Main: 0
            // DoSomething: 0
            // DoSomething: 1
            // Main: 1
            // Main: 2
            // DoSomething: 2
            // DoSomething: 3
            // Main: 3
            // Main: 4
            // DoSomething: 4
            // Waiting until thread stops...
            // Finished 
            Console.WriteLine("Starting thread...");
            t1.Start();

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($"Main: {i}");
                Thread.Sleep(10);
            }

            Console.WriteLine("Waiting until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
