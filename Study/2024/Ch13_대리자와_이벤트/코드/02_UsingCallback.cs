using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 8
이름 : 배성훈
내용 : 
    교재 p 460 ~ 464

    프로그래밍을 하다보면 값이 아닌 코드 자체를 매개변수에 넘기고 싶을 때가 많다.
    대표적으로 정렬하는 경우가 있다.

    코드를 매개변수로 넘긴다는 뜻은 정렬로 보면 비교 방법이 된다.
*/

namespace Study._2024.Ch13_대리자와_이벤트.코드
{
    internal class _02_UsingCallback
    {

        delegate int Compare(int a, int b);

        static int AscendCompare(int a, int b)
        {

            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int DescendCompare(int a, int b)
        {

            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static void BubbleSort(int[] DataSet, Compare Comparer)
        {

            int i = 0;
            int j = 0;
            int temp = 0;

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

        static void Main2(string[] args)
        {

            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, new Compare(AscendCompare));

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting descending...");
            BubbleSort(array2, new Compare(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");

            Console.WriteLine();
        }
    }
}
