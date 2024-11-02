using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : IEnumerator
    교재 p 398 ~ 400

    IEnumerator는
    bool MoveNext(), 
    void Reset(), 
    object Current()
    를 갖고 있다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    using Mysqlx.Session;
    using System.Collections;

    internal class _17_Enumerable
    {

        class MyList : IEnumerable, IEnumerator
        {

            private int[] array;
            int position = -1;

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
            public object Current { get { return array[position]; } }

            public bool MoveNext()
            {

                if (position == array.Length - 1)
                {

                    Reset();
                    return false;
                }

                position++;
                return (position < array.Length);
            }

            public void Reset()
            {

                position = -1;
            }

            public IEnumerator GetEnumerator()
            {

                return this;
            }
        }

        static void Main17(string[] args)
        {

            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            // 0 1 2 3 4
            foreach(int e in list)
                Console.WriteLine(e);
        }
    } 
}
