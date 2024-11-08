using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 8
이름 : 배성훈
내용 : 익명 메소드
    교재 p 472 ~ 475

    메소드는 한정자가 없어도 반환할 값이(void) 없어도 매개변수가 없어도 되지만 이름은 있어야 한다.

    익명 메소드(Anonymous Method)는 이름이 없는 메소드를 말한다.
    대리자의 인스턴트를 만들고 이 인스턴스가 메소드의 구현이 담겨 잇는 코드 블록을 참조 시키면 익명 메소드가 된다.

    익명 메소드는 delegate 키워드를 이용하여 선언된다.
    익명 메소드는 자신을 참조할 대리자의 형식과 동일한 형식으로 선언되어야 한다.
    대리자가 참조할 메소드를 넘겨야 할 일이 생겼는데, 다시 쓸일이 없다고 판단되면 익명 메소드를 사용할 타이밍이다.
*/

namespace Study._2024.Ch13_대리자와_이벤트.코드
{
    internal class _05_AnonymousMethod
    {

        delegate int Compare(int a, int b);

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

        static void Main5(string[] args)
        {

            int[] array = { 3, 7, 4, 2, 10 };
            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, delegate (int a, int b)
            {

                if (a > b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting descending...");
            BubbleSort(array2, delegate (int a, int b)
            {

                if (a < b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");

            Console.WriteLine();
        }
    }
}
