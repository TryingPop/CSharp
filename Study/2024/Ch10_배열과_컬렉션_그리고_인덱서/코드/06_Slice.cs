using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 배열 분할하기
    교재 p 369 ~ 372

    C# 8.0에서 도입된 System.Range이 있다.
    System.Range는 시작_인덱스..끝_인덱스 형태로 정의할 수 있다.
    System.Range는  시작 인덱스를 가진 System.Index 구조체와 끝 인덱스를 가진 System.Index를 포함하는 구조체이다.
    만약 시작_인덱스를 생략하면 0으로 채우고 끝_인덱스를 생략하면 배열의 길이 -1 즉 ^1을 채운다
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _06_Slice
    {

        static void PrintArray(System.Array array)
        {

            foreach (var e in array)
                Console.Write(e);
            Console.WriteLine();
        }

        static void Main6(string[] args)
        {

            char[] array = new char['Z' - 'A' + 1];
            for (int i = 0; i < array.Length; i++)
                array[i] = (char)('A' + i);
            
            // ABCDEFGHIJKLMNOPQRSTUVWXYZ
            PrintArray(array[..]);

            // FGHIJKLMNOPQRSTUVWXYZ
            PrintArray(array[5..]);

            Range range_5_10 = 5..10;
            // FGHIJ
            PrintArray(array[range_5_10]);

            Index last = ^0;
            Range range_5_last = 5..last;
            // FGHIJKLMNOPQRSTUVWXYZ
            PrintArray(array[range_5_last]);

            // XYZ
            PrintArray(array[^4..^1]);
        }
    }
}
