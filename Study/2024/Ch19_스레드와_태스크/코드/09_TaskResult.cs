using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 5
이름 : 배성훈
내용 : 비동기 실행 결과를 주는 Task<TResult> 클래스
    교재 p 683 ~ 687

    Task<TResult>는 코드의 비동기 실행결과를 취합할 수 있도록 도와준다.
    Task는 비동기 인자로 Action을 받는 대신 Task<TResult>는 Func를 대리자로 받는다.
*/

namespace Study._2024.Ch19_스레드와_태스크.코드
{
    internal class _09_TaskResult
    {

        static bool IsPrime(long number)
        {

            if (number < 2)
                return false;

            if (number % 2 == 0 && number != 2)
                return false;

            for (long i = 2; i < number; i++)
            {

                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main9(string[] args)
        {

            // long from = Convert.ToInt64(args[0]);
            // long to = Convert.ToInt64(args[1]);

            // int taskCount = Convert.ToInt32(args[2]);
            long from = 0;
            long to = 100_000;

            int taskCount = 5;

            Func<object, List<long>> FindPrimeFunc = (objRange) =>
            {

                long[] range = (long[])objRange;
                List<long> found = new List<long>();

                for (long i = range[0]; i < range[1]; i++)
                {

                    if (IsPrime(i))
                        found.Add(i);
                }

                return found;
            };

            Task<List<long>>[] tasks = new Task<List<long>>[taskCount];
            long currentFrom = from;
            long currentTo = to / tasks.Length;

            for (int i = 0; i < tasks.Length; i++)
            {

                Console.WriteLine("Task[{0}] : {1} ~ {2}", 
                    i, currentFrom, currentTo);

                tasks[i] = new Task<List<long>>(FindPrimeFunc,
                    new long[] { currentFrom, currentTo });
                currentFrom = currentTo + 1;

                if (i == tasks.Length - 2)
                    currentTo = to;
                else
                    currentTo = currentTo + (to / tasks.Length);
            }

            Console.WriteLine("Please press enter to start...");
            Console.ReadLine();
            Console.WriteLine("Started...");

            DateTime startTime = DateTime.Now;

            foreach (Task<List<long>> task in tasks)
                task.Start();

            List<long> total = new List<long>();

            foreach (Task<List<long>> task in tasks)
            {

                task.Wait();
                total.AddRange(task.Result.ToArray());
            }

            DateTime endTime = DateTime.Now;

            TimeSpan elapsed = endTime - startTime;

            Console.WriteLine("Prime number count between {0} and {1} : {2}", 
                from, to, total.Count);

            Console.WriteLine("Elapsed time : {0}", elapsed);
        }
    }
}
