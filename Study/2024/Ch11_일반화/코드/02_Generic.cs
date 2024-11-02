using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : 일반화 클래스
    교재 p 409 ~ 413

    일반화 클래스도 형식 매개변수가 있는 것을 제외하면 보통 클래스와 같다.
*/

namespace Study._2024.Ch11_일반화.코드
{
    internal class _02_Generic
    {

        class MyList<T>
        {

            private T[] array;

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
                        Console.WriteLine($"Array Resize : {array.Length}");
                    }

                    array[index] = value;
                }
            }

            public int Length { get { return array.Length; } }
        }

        static void Main2(string[] args)
        {

            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";    // Array Resize : 4
            str_list[4] = "mno";    // Array Resize : 5

            // abc
            // def
            // ghi
            // jkl
            // mno
            for (int i = 0; i < str_list.Length; i++)
                Console.WriteLine(str_list[i]);

            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;        // Array Resize : 4
            int_list[4] = 4;        // Array Resize : 5


            // 0
            // 1
            // 2
            // 3
            // 4
            for (int i = 0; i < int_list.Length; i++)
                Console.WriteLine(int_list[i]);
        }
    }
}
