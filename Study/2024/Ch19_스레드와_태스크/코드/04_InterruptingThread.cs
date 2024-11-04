using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 4
이름 : 배성훈
내용 : 인터럽트
    교재 p 658 ~ 661

    인터럽트는 스레드가 Running 상태를 피해 WaitJoinSleep 상태에 들어갔을 때 종료하는 방법이다.
    절대로 중단되면 안되는 작업을 하고 있을 대 중단되지 않는다는 보장을 받을 수 있다.
*/

namespace Study._2024.Ch19_스레드와_태스크.코드
{
    internal class _04_InterruptingThread
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

                    Console.WriteLine("Running thread isn't gonna be interrupted");
                    // Thread가 3초동안 Running 상태로 유지되게 한다.
                    Thread.SpinWait(30_000_000);

                    while (count > 0)
                    {

                        Console.WriteLine($"{count--} left");

                        Console.WriteLine("Entering into WaitJoinSleep State...");
                        Thread.Sleep(10);
                    }

                    Console.WriteLine("Count : 0");
                }
                catch(ThreadInterruptedException e)
                {

                    Console.WriteLine(e);
                }
                finally
                {

                    Console.WriteLine("Clearing resource...");
                }
            }
        }

        static void Main4(string[] args)
        {

            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Starting thread...");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Interrupting thread...");
            t1.Interrupt();

            Console.WriteLine("Waiting until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
