using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 로컬 함수
    교재 p 213 ~ 215

    로컬 함수는 메소드 안에서 선언되고,
    선언된 메소드 안에서만 사용되는 특별한 함수이다.

    클래스의 멤버가 아니기 때문에 메소드가 아니라 함수라고 부른다
    선언 방법은 메소드와 다르지 않지만, 로컬함수는 자신이 존재하는 지역에 선언되어 있는 변수를 사용할 수 있다.
*/

namespace Study._2024.Ch06_메소드.코드
{
    internal class _11_LocalFunction
    {

        static string ToLowerString(string input)
        {

            var arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {

                if (arr[i] < 65 || arr[i] > 90) // A ~ Z의 ASCII 값 : 65 ~ 90
                    return arr[i];
                else                            // a ~ z의 ASCII 값 : 97 ~ 122
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        static void Main11(string[] args)
        {

            Console.WriteLine(ToLowerString("Hello!"));         // hello!
            Console.WriteLine(ToLowerString("Good Morning."));  // good morning.
            Console.WriteLine(ToLowerString("This is C#."));    // this is c#.
        }
    }
}
