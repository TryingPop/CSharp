using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 프로퍼티와 생성자
    교재 p 332 ~ 334

    객체를 생성할 때 프로퍼티에 원하는 값으로 초기화할 수 있다.
*/

namespace Study._2024.Ch09_프로퍼티.코드
{
    internal class _03_ConstructorWithProperty
    {

        class BirthdayInfo
        {

            public string Name { get; set; }
            public DateTime Birthday { get; set; }

            public int Age { get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; } }
        }

        static void Main3(string[] args)
        {

            BirthdayInfo birth = new BirthdayInfo()
            {

                Name = "서현",
                Birthday = new DateTime(1991, 6, 28)
            };

            Console.WriteLine($"Name: {birth.Name}");
            Console.WriteLine($"Birthday: {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age: {birth.Age}");
        }
    }
}
