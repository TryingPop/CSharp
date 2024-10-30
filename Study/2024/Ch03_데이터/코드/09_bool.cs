using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 논리 형식
    교재 p 64 ~ 66

    참과 거짓 두 가지를 담고 잇는 데이터이다
    프로그래밍에서 가장 많이 사용되는 데이터 형식 중 하나이다
    1비트로 참과 거짓을 표현할 수 있지만 기본적으로 다루는 데이터의 크기가
    바이트이기에 1바이트 크기를 사용한다
*/

namespace Study._2024.Ch03
{
    internal class _09_bool
    {

        static void Main9(string[] args)
        {

            bool a = true;
            bool b = false;

            Console.WriteLine(a);   // True
            Console.WriteLine(b);   // False
        }
    }
}
