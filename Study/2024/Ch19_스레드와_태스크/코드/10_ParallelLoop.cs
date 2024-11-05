using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 5
이름 : 배성훈
내용 : 병렬 처리를 하는 Parallel 클래스
    교재 p 687 ~ 690

    Parallel.For 메소드는 (from, to, Method(int num))
    을 인자로 받는데 이는 from ~ to사이의 모든 값 i에 대해 Method(i)를 실행한다는 뜻이다.
    즉, from = 0, to = 10이면 Method(0), Method(1), ..., Method(10)까지 실행된다.
    그리고 스레드의 개수는 Parallel 클래스가 알아서 정한다.
*/

namespace Study._2024.Ch19_스레드와_태스크.코드
{
    internal class _10_ParallelLoop
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

        static void Main10(string[] args)
        {

            long from = 1;
            long to = 100_000;

            Console.WriteLine("Please press enter to start");
            Console.ReadLine();
            Console.WriteLine("Started...");

            DateTime startTime = DateTime.Now;
            List<long> total = new List<long>();

            Parallel.For(from, to, (long i) =>
            {

                if (IsPrime(i))
                    lock (total)
                        total.Add(i);
            });

            DateTime endTime = DateTime.Now;

            TimeSpan elapsed = endTime - startTime;

            Console.WriteLine("Prime number count between {0} and {1} : {2}",
                from, to, total.Count);
            Console.WriteLine("Elapsed time : {0}", elapsed);
        }
    }
}
