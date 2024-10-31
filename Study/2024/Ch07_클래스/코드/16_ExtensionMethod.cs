using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 확장 메소드
    교재 p 276 ~ 279

    확장 메소드는 기존 클래스의 기능을 확장하는 기법이다.
    기반 클래스를 물려받아 파생 클래스를 만든 뒤 여기에 필드나 메소드를 추가하는 상속과는 다르다.

    확장 메소드를선언하는 방법은 메소드를 선언하되, static 한정자로 수식해야 한다.
    첫 번째 매개변수는 반드시 this 키워드와 함께 확장하고자 하는 클래스의 인스턴스여야 한다.

    확장 메소드 역시 static으로 선언해야 한다.
*/

namespace Study._2024.Ch07_클래스.코드
{

    public static class IntegerExtension
    {

        public static int Square(this int myInt)
        {

            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {

            int result = myInt;
            for (int i = 1; i < exponent; i++)
                result = result * myInt;

            return result;
        }
    }


    internal class _16_ExtensionMethod
    {

        static void Main16(string[] args)
        {

            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");
        }
    }
}
