using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 프로퍼티
    교재 p 323 ~ 328

    은닉성과 편의성은 함께할 수 없는거처럼 보인다.
    프로퍼티를 이용하면 함께할 수 있다.

    프로퍼티 선언에서 set, get을 접근자(Accessor)라고 한다.
    get 접근자는 필드로부터 값을 읽어오고 set 접근자는 필드에 값을 할당한다.

    메소드를 통해 필드가 변경되지 않기를 원할 때에는 바꾸는 메소드를 구현 안하면 되듯이
    프로퍼티도 필드가 변경되지 않기를 바라면 set을 구현하지 않으면 된다.
*/

namespace Study._2024.Ch09_프로퍼티.코드
{
    internal class _01_Property
    {

        class BirthdayInfo
        {

            private string name;
            private DateTime birthday;

            public string Name
            {

                get
                {

                    return name;
                }
                set
                {

                    name = value;
                }
            }

            public DateTime Birthday
            {

                get
                {

                    return birthday;
                }
                set
                {

                    birthday = value;
                }
            }

            public int Age
            {

                get
                {

                    return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
                }
            }

            static void Main1(string[] args)
            {

                BirthdayInfo birth = new BirthdayInfo();
                birth.Name = "서현";
                birth.Birthday = new DateTime(1991, 6, 28);

                Console.WriteLine($"Name: {birth.Name}");                               // Name: 서현
                Console.WriteLine($"Birthday: {birth.Birthday.ToShortDateString()}");   // Birth: 1991- 06-28
                Console.WriteLine($"Age: {birth.Age}");                                 // 34 (2024. 11 기준)
            }
        }
    }
}
