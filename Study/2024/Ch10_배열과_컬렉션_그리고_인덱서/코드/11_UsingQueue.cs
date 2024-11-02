using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : Queue
    교재 p 384 ~ 386

    선입선출 자료구조다.
    ArrayList와 마찬가지로 object 타입을 담는다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _11_UsingQueue
    {

        static void Main11(string[] args)
        {

            System.Collections.Queue que = new System.Collections.Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            // 1 2 3 4 5
            while (que.Count > 0)
                Console.WriteLine(que.Dequeue());
        }
    }
}
