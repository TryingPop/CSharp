/* 날짜 : 22.08.11
 * 내용 : Thread - lock, Monitor를 이용해 특정 구간에 쓰레드 중복 진입 막기
 */


namespace Private
{
    internal class _20_Thread
    {
        static void Main20(string[] args)
        {
            // var source = new CancellationTokenSource();
            // var token = source.Token;
            ThreadPool.SetMinThreads(0, 0);
            ThreadPool.SetMaxThreads(7, 7);

            var cls = new _20_Thread();
            cls.UnsafeRun(); // 여러 스레드가 동시에 counter에 접근하는 것을 볼 수 있다.
            // 1003
            // 1003
            // 1003
            // 1005... 와 같이 중복값이 출력된다

            Thread.Sleep(1000);
            Console.WriteLine("lock을 이용");
            cls.SafeRun1();
            // 1001
            // 1002
            // 1003
            // 1004 ... 와 같이 중복 값 없이 출력된다

            // cls.SafeRun2();
            // 1001
            // 1002
            // 1003
            // 1004 ... 와 같이 중복 값 없이 출력된다
        }


        // lock를 이용한 예제
        private int unsafeCounter1 = 1000;
        private int safeCounter1 = 1000;
       
        private object lockObject1 = new object();

        public void UnsafeRun()
        {
            for (int i = 0; i < 10; i++)
            {
                new Thread(UnsafeCalc).Start();
            }
        }
        private void UnsafeCalc()
        {
            unsafeCounter1++;

            for (int i = 0; i < unsafeCounter1; i++)
            {
                for (int j = 0; j < unsafeCounter1; j++) ;
            }

            Console.WriteLine(unsafeCounter1);
        }

        public void SafeRun1()
        {
            for (int i = 0; i < 10; i++)
            {
                new Thread(SafeCalc1).Start();
            }
        }
        private void SafeCalc1() 
        {
            lock (lockObject1)
            {
                safeCounter1++;

                for (int i = 0; i < safeCounter1; i++)
                {
                    for (int j = 0; j < safeCounter1; j++) ;
                }
                Console.WriteLine(safeCounter1);
            }
        }

        // Monitor 클래스를 이용한 예제
        private int unsafeCounter2 = 1000;
        private int safeCounter2 = 1000;

        private object lockObject2 = new object();

        private void SafeRun2()
        {
            for (int i = 0; i < 10; i++)
            {
                new Thread(SafeCalc2).Start();
            }
        }

        private void SafeCalc2()
        {
            Monitor.Enter(lockObject2);
            try
            {
                safeCounter2++;

                for (int i = 0; i < safeCounter2; i++)
                {
                    for (int j = 0; j < safeCounter2; j++) ;
                }
                Console.WriteLine(safeCounter2);
            }
            finally
            {
                Monitor.Exit(lockObject2);
            }
        }
    }
}

// 참고 사이트
// https://www.csharpstudy.com/Threads/lock.aspx

// 나중에 참고해보기
// https://rito15.github.io/posts/cs-task/

// Thread의 상태
// https://nshj.tistory.com/entry/C-%EA%B8%B0%EC%B4%88%EB%AC%B8%EB%B2%95-11-%EC%93%B0%EB%A0%88%EB%93%9CThread%EC%99%80-%ED%85%8C%EC%8A%A4%ED%81%ACTask


// lock 키워드는 Monitor의 Enter(), Exit() 메서드로 구현한 것