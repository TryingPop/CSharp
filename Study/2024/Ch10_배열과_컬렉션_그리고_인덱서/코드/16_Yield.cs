using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 2
이름 : 배성훈
내용 : foreach 문 가능한 객체 만들기
    교재 p 396 ~ 397

    object에서 사용하기 위해서는 IEnumerable을 상속해야지 foreach 문을 이용할 수 있다.
    IEnumerable이 갖고 있는 메소드는 GetEnumerator 메소드 하나 뿐이다.
    yield문을 이용하면 컴파일러가 알아서 IEnumerable을 상속하지 않아도 상속해준다.
*/

namespace Study._2024.Ch10_배열과_컬렉션_그리고_인덱서.코드
{
    internal class _16_Yield
    {

        class MyEnumerator
        {

            int[] numbers = { 1, 2, 3, 4 };

            // 해당 메소드를 구현하면 IEnumerable 클래스를 상속한다.
            public System.Collections.IEnumerator GetEnumerator()
            {

                // yield 구문의 도움을 받아 IEnumerator 상속을 피했다.
                yield return numbers[0];
                yield return numbers[1];
                yield return numbers[2];
                yield break;
                yield return numbers[3];
            }
        }

        static void Main16(string[] args)
        {

            var obj = new MyEnumerator();

            // 1 2 3
            foreach(int i in obj)
                Console.WriteLine(i);
        }
    }
}
