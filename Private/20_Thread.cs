namespace Private
{
    internal class _20_Thread
    {
        class obj
        {
            public int num;
            public int time;
            public string name;

            public obj(int num, int time, string name)
            {
                this.num = num;
                this.time = time;
                this.name = name;
            }
        }
        public static void Test1(object? obj)
        {
            obj a = obj as obj;

            Console.WriteLine($"{a.name} : 스레드 시작 ...");
            Console.WriteLine();
            for (int i = 0; i < a.num; i++)
            {
                Thread.Sleep(a.time);
            }
            Console.WriteLine($"{a.name} : 스레드 종료 ...");
            Console.WriteLine();
        }

        public static async Task Test3(Task task)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            
            Task.Run(() =>
            {
                Thread.Sleep(50);
                cts.Cancel();
            }) ;

            task.Wait(cts.Token);
        }




        static void Main(string[] args)
        {
            var source = new CancellationTokenSource();
            var token = source.Token;



            ThreadPool.SetMinThreads(0, 0);
            ThreadPool.SetMaxThreads(7, 7);

            Task task1 = new Task(Test1, new obj(100, 100, "A"));
            Task task2 = new Task(Test1, new obj(100, 100, "B"));
            Task task3 = new Task(Test1, new obj(200, 100, "C"));
            Task task4 = new Task(Test1, new obj(200, 100, "D"));

            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();

            Test3(task4);

            
            task4.Wait();
            while (Console.KeyAvailable == false)
            {
                Thread.Sleep(250);
            }
            Console.WriteLine("키 입력 완료 ... ");
            // task1.Wait();
            // task2.Wait();
            // task3.Wait();

        }
    }
}

// 참고 사이트
// https://rito15.github.io/posts/cs-task/