using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 8
이름 : 배성훈
내용 : 일반화 대리자
    교재 p 464 ~ 468

    대리자는 메소드 뿐만 아니라 일반화 메소드도 참조할 수 있다.
    대리자도 일반화 메소드를 참조할 수 있도록 형식 매개변수를 이요하여 선언되어야 한다.
*/

namespace Study._2024.Ch13_대리자와_이벤트.코드
{
    internal class _03_GenericDelegate
    {

        delegate int Compare<T>(T a, T b);

        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {

            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {

            return b.CompareTo(a);
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {

            int i = 0;
            int j = 0;
            T temp;

            for (i = 0; i < DataSet.Length - 1; i++)
            {

                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {

                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {

                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main3(string[] args)
        {

            int[] array = { 3, 7, 4, 2, 10 };
            Console.WriteLine("Sorting ascending...");
            BubbleSort<int>(array, new Compare<int>(AscendCompare));

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };

            Console.WriteLine("\nSorting descending...");
            BubbleSort<string>(array2, new Compare<string>(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");
            Console.WriteLine();
        }
    }
}
