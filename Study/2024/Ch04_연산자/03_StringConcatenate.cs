using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 28
이름 : 배성훈
내용 : 문자열 결합 연산자
    교재 p 122 ~ 123

    문자열에서 +연산자는 결합연산자가 된다
    문자열 결합 연산자는 뒤의 문자열을 앞의 문자열에 이어붙인 새로운 문자열을 반환한다
*/

namespace Study._2024.Ch04
{
    internal class _03_StringConcatenate
    {

        static void Main3(string[] args)
        {

            string result = "123" + "456";
            Console.WriteLine(result);          // 123456

            result = "Hello" + " " + "World!";
            Console.WriteLine(result);          // Hello World!
        }
    }
}
