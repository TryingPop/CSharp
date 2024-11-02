using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : ArrayList
    교재 p381 ~ 383

    ArrayList는 object 타입으로 자료를 저장한다.
    그래서 박싱이 일어나고 원래 데이터를 사용할 때는 언박싱이 이뤄진다.
    이는 오버헤드가 일어나고 ArrayList가 다루는 데이터가 많으면 많아질수록 성능저하가 심하다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _10_UsingList
    {

        static void Main10(string[] args)
        {

            ArrayList list = new ArrayList();
            for (int i = 1; i < 6; i++)
                list.Add(i);

            // 1 2 3 4 5
            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.RemoveAt(2);

            // 1 2 4 5
            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            // 1 2 2 4 5
            list.Insert(2, 2);
            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            // 1 2 2 4 5 abc def
            for (int i = 0; i < list.Count; i++)
                Console.Write($"{list[i]} ");
            Console.WriteLine();
        }
    }
}
