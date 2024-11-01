using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 연습문제 2
    교재 p 354

    다음 프로그램을 완성해서 다음과 같은 결과를 출력하도록 하세요.
    단, 무명 형식을 이용해야 합니다.

    출력 결과
        이름: 박상현, 나이: 17
        Real:3, Imaginary:-12

    코드
        using System;

        static void Main()
        {

            var nameCard = // 무명 형식을 이용해서 완성하세요.
            Console.WriteLine("이름: {0}, 나이: {1}", 
                    nameCard.Name, nameCard.Age);

            var complex = // 무명 형식을 이용해서 완성하세요.
            Console.WriteLine("Real: {0}, Imaginary: {1}",
                    complex.Real, complex.Imaginary);
        }
*/

namespace Study._2024.Ch09_프로퍼티.코드
{
    internal class _12_ex_02
    {

        static void Main12(string[] args)
        {

            var nameCard = new { Name = "박상현", Age = 17 };
            Console.WriteLine("이름: {0}, 나이: {1}",
                    nameCard.Name, nameCard.Age);

            var complex = new { Real = 3, Imaginary = -12 };
            Console.WriteLine("Real: {0}, Imaginary: {1}",
                    complex.Real, complex.Imaginary);
        }
    }
}
