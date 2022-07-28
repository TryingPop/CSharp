using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 12-2
 * 
 * Linq를 사용해 간단하게 작성
 */

namespace Book.Ch12
{
    internal class ex02
    {
        static void Main2(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var output = from item in input
                         where item % 2 == 0
                         select item;

            // List<int> change = (output as List<int>);
            // foreach 같은게 iterator(반복자)의 예시
            // iterator(반복자, 반복기) : 배열의 내부 요소를 순회하는 객체
            // Array는 메모리에 요소들을 전부 포함한다
            // 반면, iterator는 메서드랑 쓰는거만 메모리에 포함
            // Enumerable : Enumerable<T> 를 구현하는 개체를 쿼리하기 위한 static 메서드 집합 제공하는 클래스
        }
    }
}


/*
// 예를들면
static void Main()
{
    foreach (int number in EvenSequence(5, 18))
    {
        Console.Write(number.ToString() + " ");
    }
    // Output: 6 8 10 12 14 16 18
    Console.ReadKey();
}

// 단순 iterator
// C#에서는 IEnumerable 타입이면 이터레이터의 한 종류
public static System.Collections.Generic.IEnumerable<int>
    EvenSequence(int firstNumber, int lastNumber)
{
    // Yield even numbers in the range.
    for (int number = firstNumber; number <= lastNumber; number++)
    {
        if (number % 2 == 0)
        {
            yield return number;
        }
    }
}

// 메모리 상에 EvenSequence() 메서드 내용이 담기고
// 받는 변수
// 지역 변수가 담긴다
// 그리고 지역변수값이 변하면서 output을 출력한다

 */