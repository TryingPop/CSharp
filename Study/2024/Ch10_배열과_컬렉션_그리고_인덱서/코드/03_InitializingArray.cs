using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 배열의 초기화
    교재 p 362 ~ 364

    배열을 초기화하는 방법은 다음과 같이 3가지가 있다.
    초기화하는 중괄호 {} 블록을 가리켜 컬렉션 초기자(Collection Initializer)라고 부른다.

    먼저 원소의 개수를 명시하고 컬렉션 초기자에 같은 개수의 원소를 채워넣는다.

    다음으로 원소의 개수를 명시하지 않고 컬렉션 초기자에 원소를 채워넣는다. 그러면 컴파일러에서 알아서 채워준다.

    마지막으로 컬렉션 초기자 안에 원소를 넣어 초기화한다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _03_InitializingArray
    {

        static void Main3(string[] args)
        {

            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };
            Console.WriteLine("array1...");
            foreach(string greeting in array1)
                Console.WriteLine($" {greeting}");

            string[] array2 = new string[] { "안녕", "Hello", "Halo" };
            Console.WriteLine("\narray2");
            foreach(string greeting in array2)
                Console.WriteLine($" {greeting}");

            string[] array3 = { "안녕", "Hello", "Halo" };
            Console.WriteLine("\narray3");
            foreach(string greeting in array3)
                Console.WriteLine($" {greeting}");
        }
    }
}
