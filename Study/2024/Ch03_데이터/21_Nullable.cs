using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : Nullable 형식
    교재 p 85 ~ 88

    값형식에 한해서 어떤 값도 가지지 않는 변수가 필요하다
    0도 아닌 비어있는 변수를 선언할 때 Nullable 형식을 사용한다
    참조 형식에서는 사용 불가능하고 값 형식에서만 사용할 수 있다

    Nullable 형식은
    값 자료형 앞에 ?을 붙여 선언할 수 있다
    해당 구조체는 struct 를 사용하는 제네릭 형식이다
    hasValue로 값이 있는지를 나타내고, Value에 값을 담는다
*/

namespace Study._2024.Ch03
{
    internal class _21_Nullable
    {

        static void Main21(string[] args)
        {

            int? a = null;

            Console.WriteLine(a.HasValue);      // False
            Console.WriteLine(a != null);       // False

            a = 3;

            Console.WriteLine(a.HasValue);      // True
            Console.WriteLine(a != null);       // True
            Console.WriteLine(a.Value);         // 3
        }
    }
}
