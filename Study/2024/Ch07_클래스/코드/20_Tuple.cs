using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 튜플
    교재 p 287 ~ 290

    튜플(Tuple)도 여러 필드를 담을 수 잇는 구조체이다.
    튜플은 형식 이름이 없다.

    튜플은 응용 프로그램 전체에서 사용할 형식을 선언할 때가 아닌, 
    즉석에서 사용할 복합 데이터 형식을 선언할 때 적합하다.
    튜플은 구조체이므로 값 형식이다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _20_Tuple
    {

        static void Main20(string[] args)
        {

            // 명명되지 않은 튜플
            var a = ("슈퍼맨", 999);
            Console.WriteLine($"{a.Item1}, {a.Item2}"); // 슈퍼맨, 999

            // 명명된 튜플
            var b = (Name: "박상현", Age: 17);
            Console.WriteLine($"{b.Name}, {b.Age}");    // 박상현, 17

            // 분해 1
            var (name, age) = b;
            Console.WriteLine($"{name} {age}");         // 박상현, 17

            // 분해 2
            var (name2, age2) = ("박문수", 34);
            Console.WriteLine($"{name2}, {age2}");      // 박문수, 34

            // 명명된 튜플 = 명명되지 않은 튜플
            b = a;
            Console.WriteLine($"{b.Name}, {b.Age}");    // 슈퍼맨 999
        }
    }
}
