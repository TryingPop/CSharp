using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : Object 형식
    교재 p66 ~ 68

    object는 물건 객체라는 뜻의 영어 단어이다
    object 형식은 어떤 데이터든지 다룰 수 있는 데이터 형식이다

    모든 데이터 형식(기본 데이터 형식뿐 아니라 복합 데이터 형식)은 
    자동으로 object 형식으로부터 상속 받게 한 것이다
*/

namespace Study._2024.Ch03
{
    internal class _10_Object
    {


        static void Main10(string[] args)
        {

            object a = 123;
            object b = 3.141592653589793238462643383279m;
            object c = true;
            object d = "안녕하세요.";

            Console.WriteLine(a);   // 123
            Console.WriteLine(b);   // 3.1415926535897932384626433833
            Console.WriteLine(c);   // true
            Console.WriteLine(d);   // 안녕하세요.
        }
    }
}
