using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private
{
    internal class _1_async__await
    {
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

            await task;

            return task.Result;
        }

        class Node
        {
            public string Text { get; set; }
            public int Count { get; set; }
            public int Tick { get; set; }
        }

        static void Main(string[] args)
        {
            // ThreadPool의 갯수 제한 0 ~ 2개
            ThreadPool.SetMinThreads(0, 0);
            ThreadPool.SetMaxThreads(2, 0);

            var list = new List<Task<int>>();

            var func = new Func<object, int>((x) =>
            {
                var node = (Node)x;

                int sum = 0;

                for (int i = 0; i <= node.Count; i++)
                {
                    sum += i;
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

            Console.WriteLine("비교 1번 끝");
            Console.WriteLine();


            list = new List<Task<int>>();
            list.Add(RunAsync(new Node { Text = "A", Count = 5, Tick = 1000 }));
            list.Add(RunAsync(new Node { Text = "B", Count = 5, Tick = 10 }));
            list.Add(RunAsync(new Node { Text = "C", Count = 5, Tick = 500 }));
            list.Add(RunAsync(new Node { Text = "D", Count = 5, Tick = 300 }));
            list.Add(RunAsync(new Node { Text = "E", Count = 5, Tick = 200 }));
            list.Add(RunAsync(new Node { Text = "F", Count = 5, Tick = 100 }));

            Console.WriteLine("Sum = " + list.Sum(x => x.Result));
            Console.WriteLine("비교 2번 끝");
            Console.WriteLine();
        }
    }
}


// https://nowonbun.tistory.com/415 3번째 비교문 참조하기!