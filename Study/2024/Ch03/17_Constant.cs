using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 27
이름 : 배성훈
내용 : 상수
    교재 p78 ~ 80

    상수는 변경되면 안되는 자료형에 쓴다
    프로그래머도 사람이고 실수를 할 수 있어
    상수 값이 변경되었다면 컴파일에러를 일으켜 알려주는 역할을 한다
*/

namespace Study._2024.Ch03
{
    internal class _17_Constant
    {

        static void Main17(string[] args)
        {

            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483648;

            Console.WriteLine(MAX_INT); // 2147483647
            Console.WriteLine(MIN_INT); // -2147483648

            const int a = 3;
            // a = 4;  // 컴파일 에러 발생
        }
    }
}
