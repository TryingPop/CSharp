using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 5
이름 : 배성훈
내용 : 
    교재 p 672 ~ 677

    Monitor를 사용한다면 Wait과 Pulse 때문일 것이다.
    Monitor 클래스는 lock 키워드보다 더 섬세하게 멀티 스레드간의 동기화를 가능하게 해준다.

    섬세한 동기화 제어는 그만큼 일이 늘어날 것이다.
    Wait과 Pulse는 CLR이 SynchronizationLockException 예외를 던지는 광경을 봐야 한다.
*/

namespace Study._2024.Ch19_스레드와_태스크.코드
{
    internal class _07_WaitPulse
    {

        class Counter
        {

            const int LOOP_COUNT = 1000;

            readonly object thisLock;
            bool lockedCount = false;

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

                    lock (thisLock)
                    {

                        while(count > 0 || lockedCount)
                            Monitor.Wait(thisLock);

                        lockedCount = true;
                        count++;
                        lockedCount = false;

                        Monitor.Pulse(thisLock);
                    }
                }
            }

            public void Decrease()
            {

                int loopCount = LOOP_COUNT;

                while(loopCount-- > 0)
                {

                    lock (thisLock)
                    {

                        while (count < 0 || lockedCount)
                            Monitor.Wait(thisLock);

                        lockedCount = true;
                        count--;
                        lockedCount = false;

                        Monitor.Pulse(thisLock);
                    }
                }
            }
        }

        static void Main7(string[] args)
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
