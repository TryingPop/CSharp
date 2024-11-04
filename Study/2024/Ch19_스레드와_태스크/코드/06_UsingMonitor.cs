using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 4
이름 : 배성훈
내용 : Monitor 클래스로 동기화
    교재 p 668 ~ 

    Monitor를 이용해 동기화하는 경우 정상적인 반환을 위해
    try - finally 문을 이용해 Monitor.Exit()을 호출해야 한다.
*/

namespace Study._2024.Ch19_스레드와_태스크.코드
{
    internal class _06_UsingMonitor
    {

        class Counter
        {

            const int LOOP_COUNT = 1000;

            readonly object thisLock;
                private int count;
            public int Count
            {

                get { return count; }
            }

            public Counter()
            {

                thisLock = new object();
                count = 0;
            }

            public void Increase()
            {

                int loopCount = LOOP_COUNT;
                while(loopCount-- > 0)
                {

                    Monitor.Enter(thisLock);
                    try
                    {

                        count++;
                    }
                    finally
                    {

                        Monitor.Exit(thisLock);
                    }

                    Thread.Sleep(1);
                }
            }

            public void Decrease()
            {

                int loopCount = LOOP_COUNT;
                while(loopCount-- > 0)
                {

                    Monitor.Enter(thisLock);
                    try
                    {

                        count--;
                    }
                    finally
                    {

                        Monitor.Exit(thisLock);
                    }

                    Thread.Sleep(1);
                }
            }
        }

        static void Main6(string[] args)
        {

            Counter counter = new Counter();

            Thread incThread = new Thread(
                new ThreadStart(counter.Increase));

            Thread decThread = new Thread(
                new ThreadStart(counter.Decrease));

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            Console.WriteLine(counter.Count);
        }
    }
}
