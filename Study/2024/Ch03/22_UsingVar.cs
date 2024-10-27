using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : var
    교재 p 88 ~ 90

    var 형태로 선언하면 C# 컴파일러는 데이터 형식을 알아서 파악해준다
    컴파일러나 인터프리터가 해당 변수에 담는 데이터를 보고 자동으로 형식으로 지정한다
    var는 지역변수로만 사용할 수 있다
*/

namespace Study._2024.Ch03
{
    internal class _22_UsingVar
    {

        static void Main22(string[] args)
        {

            var a = 20;     // int32
            Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

            var b = 3.1414213;
            Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

            var c = "Hello, World!";
            Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

            var d = new int[] { 10, 20, 30 };
            Console.Write("Type: {0}, Value: ", d.GetType());
            foreach (var e in d)
                Console.Write("{0} ", e);

            Console.WriteLine();
        }
    }
}
