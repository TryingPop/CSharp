using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : Queue<T>
    교재 p 421

    앞과 동일하다.
*/

namespace Study._2024.Ch11_일반화.코드
{
    internal class _05_UsingGenericQueue
    {

        static void Main5(string[] args)
        {

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            // 1 2 3 4 5
            while(queue.Count > 0)
                Console.WriteLine(queue.Dequeue());
        }
    }
}
