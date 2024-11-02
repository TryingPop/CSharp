using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : 컬렉션 초기화
    교재 p 389 ~ 392

    컬렉션은 배열 정보를 넘겨 초기화할 수 있다.

    Stack과 Queue는 컬렉션 초기자를 이용할 수 없다
    이는 IEnumerable 인터페이스와 Add 메소드를 구현하는 클래스만 지원하기 때문이다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{

    using static System.Console;

    internal class _14_InitializingCollections
    {

        static void Main14(string[] args)
        {

            int[] arr = { 123, 456, 789 };

            // 123 456 789
            ArrayList list = new ArrayList(arr);
            foreach (object item in list)
                WriteLine($"ArrayList: {item}");
            WriteLine();

            // 789 456 123
            Stack stack = new Stack(arr);
            foreach (object item in stack)
                WriteLine($"Stack: {item}");
            WriteLine();

            // 123 456 789
            Queue queue = new Queue(arr);
            foreach (object item in queue)
                WriteLine($"Queue: {item}");
            WriteLine();

            // 11 22 33
            ArrayList list2 = new ArrayList() { 11, 22, 33 };
            foreach (object item in list2)
                WriteLine($"ArrayList2 : {item}");
            WriteLine();

            Hashtable ht1 = new Hashtable()
            {

                ["하나"] = 1,
                ["둘"] = 2
            };

            Hashtable ht2 = new Hashtable() 
            {

                { "하나", 1 },
                { "둘", 2 }
            };
        }
    }
}
