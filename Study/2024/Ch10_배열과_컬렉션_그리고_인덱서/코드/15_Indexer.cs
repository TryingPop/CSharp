using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : 인덱서
    교재 p 392 ~ 395

    프로퍼티는 객체 내의 데이터에 접근할 수 있도록 하는 통로이다.
    프로퍼티와 다른점은 인덱스를 이용해 접근한다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _15_Indexer
    {

        class MyList
        {

            private int[] array;

            public MyList()
            {

                array = new int[3];
            }

            public int this[int index]
            {

                get { return array[index]; }
                set
                {

                    if (index >= array.Length)
                    {

                        Array.Resize<int>(ref array, index + 1);
                        Console.WriteLine($"Array Resized : {array.Length}");
                    }

                    array[index] = value;
                }
            }

            public int Length
            {

                get { return array.Length; }
            }
        }

        static void Main15(string[] args)
        {

            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
        }
    }
}
