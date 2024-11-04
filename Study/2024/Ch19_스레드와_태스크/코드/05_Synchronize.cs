using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 4
이름 : 배성훈
내용 : 스레드간 동기화 (lock)
    교재 p 662 ~ 668

    스레드들이 순서를 갖춰 자원을 사용하게 하는 것을 일컬어 동기화(Synchronization)이라 한다.
    크리티컬 섹션(Critical Section)은 한 스레드만 사용할 수 잇는 코드영역을 말한다.
    lock 키워드로 감싸주기만 해도 크리티컬 섹션으로 바꿀 수 있다.

    크리티컬 섹션은 필요한 곳에만 사용하는게 성능에 좋다.
    lock에는 하는 오브젝트가 필요하다. this로 lock을 거는건 좋지 않다.
    string 객체는 외부에서도 같은 것을 참조하기에 절대 lock에 사용해서는 안된다.
*/

namespace Study._2024.Ch19_스레드와_태스크.코드
{
    internal class _05_Synchronize
    {

        class Counter
        {

            const int LOOP_COUNT = 1000;
            readonly object thisLock;

            private int count;
            public int Count { get { return count;} }

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

                        count++;
                    }

                    Thread.Sleep(1);
                }
            }

            public void Decrease()
            {

                int loopCount = LOOP_COUNT;
                while(loopCount-- > 0)
                {

                    lock (thisLock)
                    {

                        count--;
                    }

                    Thread.Sleep(1);
                }
            }
        }

        static void Main5(string[] args)
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
