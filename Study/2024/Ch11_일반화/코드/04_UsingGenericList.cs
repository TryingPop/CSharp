using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : List<T>
    교재 p 418 ~ 420

    앞에서 Collections의 컬렉션을 다뤘다.
    여기서는 제네릭 컬렉션을 다룬다.

    대표적으로 
        List<T>
        Queue<T>
        Stack<T>
        Dictionary<TKey, TValue>

    가 있다.

    일반화 컬렉션은 아무 원소나 담을 수 없다.
    Collections의 컬렉션은 아무 원소나 담을 수 있지만 형변환이 엄청나게 일어나 성능저하를 일으켰다.
    제네릭 컬렉션을 쓰면 사용형식이 결정되고 쓸데없는 형식 변환을 일으키지 않는다.
    잘못된 형식의 객체를 담게될 위험도 없다.
*/

namespace Study._2024.Ch11_일반화.코드
{
    internal class _04_UsingGenericList
    {

        static void Main4(string[] args)
        {

            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            // 0 1 2 3 4
            foreach(int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            list.RemoveAt(2);

            // 0 1 3 4
            foreach(int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            list.Insert(2, 2);

            // 0 1 2 3 4
            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();
        }
    }
}
