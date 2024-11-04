using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 4
이름 : 배성훈
내용 : 스레드의 일생과 상태 변화
    교재 p 651 ~ 

    스레드는 대부분 일하면서 보내지만 마냥 기다려야할 때도 있으며 강제 종료되는 경우도 있다.
    .NET은 스레드의 상태를 ThreadState 열거형에 정의해두었다.

    상태는 다음과 같다
        Unstarted       생성되었는데 Start() 메소드가 호출되기 전 상태
        Running         스레드가 동작 중인 상태
        Suspended       스레드가 일시 중지된 상태 다시 실행상태로 만들 수 있다.
        WaitSleepJoin   스레드가 블록된 상태
        Aborted         스레드가 취소된 상태
        Stopped         스레드가 중지된 상태
        Background      스레드가 백그라운드로 동작하는 상태

    상태는 아무 상태로 갈 수 있는게 아니다. 못 가는 경로가 존재한다.
    스레드 상태는 비트필드 값 형식으로 존재한다.
*/

namespace Study._2024.Ch19_스레드와_태스크.코드
{
    internal class _03_UsingThreadState
    {

        private static void PrintThreadState(ThreadState state)
        {

            Console.WriteLine("{0,-16} : {1}", state, (int)state);
        }

        static void Main3(string[] args)
        {

            PrintThreadState(ThreadState.StopRequested);                    // 1
            PrintThreadState(ThreadState.SuspendRequested);                 // 2
            PrintThreadState(ThreadState.Background);                       // 4
            PrintThreadState(ThreadState.Unstarted);                        // 8
            PrintThreadState(ThreadState.Stopped);                          // 16
            PrintThreadState(ThreadState.WaitSleepJoin);                    // 32
            PrintThreadState(ThreadState.Suspended);                        // 64
            PrintThreadState(ThreadState.AbortRequested);                   // 128
            PrintThreadState(ThreadState.Aborted);                          // 256
            PrintThreadState(ThreadState.Aborted | ThreadState.Stopped);
        }
    }
}
