using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 자동 구현 프로퍼티
    교재 p328 ~ 332

    C# 3.0부터 자동 구현 프로퍼티(Auto-Implemented Property)를 지원한다.
    필드를 선언할 필요도 없고, 그저 get 접근자와 set 접근자 뒤에 세미콜론(;)만 붙여주면 된다.

    C# 7.0부터는 자동 구현 프로퍼티를 선언함과 동시에 초기화를 수행할 수 있다.
    자동 구현 프로퍼티를 사용하면 컴파일러가 알아서 변수를 선언하고 가리킨다.
*/

namespace Study._2024.Ch09_프로퍼티.코드
{
    internal class _02_AutoImplementedProperty
    {

        class BirthdayInfo
        {

            public string Name { get; set; } = "Unknown";
            public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);

            public int Age
            {

                get
                {

                    return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
                }
            }
        }

        static void Main2(string[] args)
        {

            BirthdayInfo birth = new BirthdayInfo();
            Console.WriteLine($"Name: {birth.Name}");                               // Name: Unknown
            Console.WriteLine($"Birthday: {birth.Birthday.ToShortDateString()}");   // Birthday: 0001-01-01
            Console.WriteLine($"Age: {birth.Age}");                                 // Age: 2024

            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);

            Console.WriteLine($"Name: {birth.Name}");                               // Name: 서현
            Console.WriteLine($"Birthday: {birth.Birthday.ToShortDateString()}");   // Birthday: 1991-06-28
            Console.WriteLine($"Age: {birth.Age}");                                 // Age: 34
        }
    }
}
