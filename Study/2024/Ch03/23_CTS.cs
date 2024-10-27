using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 공용 형식 시스템
    교재 p91 ~ 93

    .NET을 지원하는 모든 언어가 함께 사용하는 데이터 형식 체계라는 의미다
    C++이 있다

    object 형식에 GetType과 ToString이 있다
*/

namespace Study._2024.Ch03
{
    internal class _23_CTS
    {

        static void Main23(string[] args)
        {

            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine("a type: {0}, value: {1}", a.GetType().ToString(), a);
            Console.WriteLine("b type: {0}, value: {1}", b.GetType().ToString(), b);

            System.String c = "abc";
            string d = "def";

            Console.WriteLine("c type: {0}, value: {1}", c.GetType().ToString(), c);
            Console.WriteLine("d type: {0}, value: {1}", d.GetType().ToString(), d);
        }
    }
}
