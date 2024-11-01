using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : System.Array
    교재 p 365 ~ 365

    .NET 의 CTS에서 배열은 System.Array 클래스에 대응된다.
    Array에는 많은 메소드들이 있다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _04_DerivedFromArray
    {

        static void Main4(string[] args)
        {

            int[] array = new int[] { 10, 30, 20, 7, 1 };
            Console.WriteLine($"Type Of array : {array.GetType()}");
            Console.WriteLine($"Base type Of array: {array.GetType().BaseType}");
        }
    }
}
