using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.07.29
 * 내용 : 스레드(Thread) - Task, async, await
 */

namespace Private
{
    internal class _01_async__await
    {
        // async : 반환 타입이 Task, Task<T>, void 로만 쓸 수있다.
        // await 코드 전까진 동기로 작용한다.
        // await 이후 코드부터 비동기로 시작
        static async Task<int> RunAsync(Node node)
        {
            var task = new Task<int>(() =>
            {
                int sum = 0;

                for(int i = 0;i <=node.Count; i++)
                {
                    sum += i;
                    Console.WriteLine(node.Text + " = " + i);

                    Thread.Sleep(node.Tick);
                }

                Console.WriteLine("Completed " + node.Text);
                return sum;
            });

            task.Start();
            // 비동기, 동기 구분 지점
            await task;

            return task.Result;
        }

        class Node
        {
            public string Text { get; set; }
            public int Count { get; set; }
            public int Tick { get; set; }
        }

        static void Main1(string[] args)
        {
            DateTime start = DateTime.Now;
            // task는 ThreadPool에서 논다?
            // ThreadPool의 갯수 제한 0 ~ 2개
            // Task에는 영향을 안미친다
            // ThreadPool.SetMinThreads(0, 0);
            // ThreadPool.SetMaxThreads(5, 0);

            var list = new List<Task<int>>();

            Func<object, int> func = new Func<object, int>((x) =>
            {
                // Task는 arg2가 object 타입을 받으므로 캐스팅이 필요
                var node = x as Node;

                int sum = 0;
               
                for (int i = 0; i <= node.Count; i++)
                {
                    sum += 1;
                    Console.WriteLine(node.Text + " = " + i);
                    Thread.Sleep(node.Tick);
                }
                Console.WriteLine("Completed " + node.Text);
                return sum;
            });

            list.Add(new Task<int>(func, new Node { Text = "A", Count = 5, Tick = 1000 }));
            list.Add(new Task<int>(func, new Node { Text = "B", Count = 5, Tick = 10 }));
            list.Add(new Task<int>(func, new Node { Text = "C", Count = 5, Tick = 500 }));
            list.Add(new Task<int>(func, new Node { Text = "D", Count = 5, Tick = 300 }));
            list.Add(new Task<int>(func, new Node { Text = "E", Count = 5, Tick = 200 }));
            list.Add(new Task<int>(func, new Node { Text = "F", Count = 5, Tick = 100 }));

            list.ForEach(x => x.Start());
            list.ForEach(x => x.Wait());

            Console.WriteLine("Sum = " +list.Sum(x=> x.Result));
            DateTime end = DateTime.Now;
            Console.WriteLine($"{(end - start).TotalSeconds}초 걸렸습니다");
            // Thread 5 개가 작업을 실행
            // ThreadPool에서 Thread 갯수 제한 건 코드가 영향을 안준다
            Console.WriteLine("비교 1번 끝");
            Console.ReadLine();



            list = new List<Task<int>>();
            list.Add(RunAsync(new Node { Text = "A", Count = 5, Tick = 1000 }));
            list.Add(RunAsync(new Node { Text = "B", Count = 5, Tick = 10 }));
            list.Add(RunAsync(new Node { Text = "C", Count = 5, Tick = 500 }));
            list.Add(RunAsync(new Node { Text = "D", Count = 5, Tick = 300 }));
            list.Add(RunAsync(new Node { Text = "E", Count = 5, Tick = 200 }));
            list.Add(RunAsync(new Node { Text = "F", Count = 5, Tick = 100 }));

            Console.WriteLine("Sum = " + list.Sum(x => x.Result));
            end = DateTime.Now;
            Console.WriteLine($"{(end - start).TotalSeconds}초 걸렸습니다");
            Console.WriteLine("비교 2번 끝");
            // Console.ReadLine();

            // Task 클래스의 메서드 이용
            list = new List<Task<int>>();
            list.Add(RunAsync(new Node { Text = "A", Count = 5, Tick = 1000 }).ContinueWith(x => x.Result * 100));
            list.Add(RunAsync(new Node { Text = "B", Count = 5, Tick = 10 }).ContinueWith(x => x.Result * 100));
            list.Add(RunAsync(new Node { Text = "C", Count = 5, Tick = 500 }).ContinueWith(x => x.Result * 100));
            list.Add(RunAsync(new Node { Text = "D", Count = 5, Tick = 300 }).ContinueWith(x => x.Result * 100));
            list.Add(RunAsync(new Node { Text = "E", Count = 5, Tick = 200 }).ContinueWith(x => x.Result * 100));
            list.Add(RunAsync(new Node { Text = "F", Count = 5, Tick = 100 }).ContinueWith(x => x.Result * 100));

            Console.WriteLine($"Sum = {list.Sum(x => x.Result)}");
            Console.WriteLine("비교 3번 끝");
            end = DateTime.Now;
            Console.WriteLine($"{(end - start).TotalSeconds}초 걸렸습니다");
            Console.WriteLine("Press Any Key...");
            Console.ReadLine();
            
        }
    }
}

// 참고 사이트
// https://nowonbun.tistory.com/415 