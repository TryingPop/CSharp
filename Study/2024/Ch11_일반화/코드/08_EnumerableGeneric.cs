using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : foreach
    교재 p 424 ~ 428

    컬렉션에서 foreach문을 사용하려면 IEnumerable 인터페이스를 상속받을 필요가 있었다.
    그리고 IEnumerator GetEnumerator 메소드를 정의하고 yield문을 쓰면 알아서 IEnumerable을 상속받았다.
    IEnumerator는 현재 위치, 그리고 초기화, 다음 위치 메소드를 포함하고 있었다.

    여기에 제네릭이라는 <T>를 붙이면 제네릭 컬렉션도 foreach문을 이용할 수 있다.
*/

namespace Study._2024.Ch11_일반화.코드
{
    using Mysqlx.Session;
    using System.Collections;

    internal class _08_EnumerableGeneric
    {

        class MyList<T> : IEnumerable<T>, IEnumerator<T>
        {

            private T[] array;
            int position = -1;

            public MyList()
            {

                array = new T[3];
            }

            public T this[int index] 
            { 
            
                get { return array[index]; }
                set
                {

                    if (index >= array.Length)
                    {

                        Array.Resize<T>(ref array, index + 1);
                        Console.WriteLine($"Array Resized: {array.Length}");
                    }

                    array[index] = value;
                }
            }

            public int Length { get { return array.Length; } }

            public IEnumerator<T> GetEnumerator() { return this; }

            IEnumerator IEnumerable.GetEnumerator() { return this; }

            public T Current { get { return array[position]; } }

            object IEnumerator.Current { get { return array[position]; } }

            public bool MoveNext()
            {

                if (position == array.Length - 1)
                {

                    Reset();
                    return false;
                }

                position++;
                return position < array.Length;
            }

            public void Reset()
            {

                position = -1;
            }

            public void Dispose() { }
        }

        static void Main8(string[] args)
        {

            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            // abc def, ghi jkl mno
            foreach(string str in str_list)
                Console.WriteLine(str);

            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;
            int_list[4] = 4;

            // 0 1 2 3 4
            foreach(int no in int_list)
                Console.WriteLine(no);
        }
    }
}
