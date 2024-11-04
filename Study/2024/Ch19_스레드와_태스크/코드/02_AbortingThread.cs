using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 4
이름 : 배성훈
내용 : 스레드 임의로 종료시키기
    교재 p 647 ~ 651

    Abort 메소드로 스레드를 종료시킬 수 있다.
    그런데 현재 Abort 메소드는 실행하는 순간 막혀 사용할 수 없다.
    교재 출력대로 안나온다.
*/

namespace Study._2024.Ch19_스레드와_태스크.코드
{
    internal class _02_AbortingThread
    {

        class SideTask
        {

            int count;
            
            public SideTask(int count)
            {

                this.count = count;
            }

            public void KeepAlive()
            {

                try
                {

                    while (count > 0)
                    {

                        Console.WriteLine($"{count--} left");
                        Thread.Sleep(10);
                    }

                    Console.WriteLine("Count: 0");
                }
                catch (ThreadAbortException e)
                {

                    Console.WriteLine(e);
                    Thread.ResetAbort();
                }
                finally
                {

                    Console.WriteLine("Clearing resource...");
                }
            }
        }

        static void Main2(string[] args)
        {



            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Starting thread");
            t1.Start();

            Thread.Sleep(100);

            // Abort는 현재 막혔다.
            // 그래서 Abort 부분에서 에러가 뜬다.
            Console.WriteLine("Aborting thread...");
            t1.Abort();

            Console.WriteLine("Waiting until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
