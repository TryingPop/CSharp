using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 무명 형식
    교재 p 344 ~ 346

    형식에 이름이 필요한 이유는 그 형식의 이름을 이용해 인스턴스를 만들기 때문이다.
    무명 형식은 형식의 선언과 동시에 인스턴스 할당을 한다.
    인스턴스를 만들고 다시는 사용하지 않을 때 무명 형식이 요긴하다.

    무명 형식은프로퍼티에 할당된 값은 변경 불가능하다.
*/

namespace Study._2024.Ch09_프로퍼티.코드
{
    internal class _08_AnonymousType
    {

        static void Main8(string[] args)
        {

            var a = new { Name = "박상현", Age = 123 };
            Console.WriteLine($"Name: {a.Name}, Age: {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };

            Console.Write($"Subject: {b.Subject}, Scores: ");
            foreach (var score in b.Scores)
                Console.Write($"{score} ");

            Console.WriteLine();
        }
    }
}
