using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : this 키워드
    교재 p 239 ~ 241

    this는 객체가 자신을 지칭할 때 사용하는키워드이다.
    객체 외부에서는 객체의 필드나 메소드에 접근할 때 객체의 이름(변수 또는 식별자)을 사용한다면
    객체 내부에서는 자신의 필드나 메소드에 접근할 때 this 키워드를 사용한다는 것이다.

    this 키워드를 사용하면 아래와 같은 예제에서 모호성을 풀 수 있다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _05_This
    {

        class Employee
        {

            private string Name;
            private string Position;

            public void SetName(string Name)
            {

                this.Name = Name;
            }

            public string GetName()
            {

                return Name;
            }

            public void SetPosition(string Position)
            {

                this.Position = Position;
            }

            public string GetPosition()
            {

                return this.Position;
            }
        }

        static void Main5(string[] args)
        {

            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");        // Pooh Waiter

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");    // Tigger Cleaner
        }
    }
}
