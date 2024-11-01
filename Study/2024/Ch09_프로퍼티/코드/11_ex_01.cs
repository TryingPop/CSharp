using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 연습문제 1
    교재 p 353

    다음 코드에서 NameCard 클래스의 GetAge(), SetAge(), GetName(), SetName() 메소드들을 프로퍼티로 변경해 작성하세요.

    코드

        using System;

        class NameCard
        {

            private int age;
            private string name;

            public int GetAge() { return age; }
            public void SetAge(int value) { age = value; }
            public string GetName() { return name; }
            public void SetName(string value) { name = value; }
        }

        static void Main()
        {

            NameCard MyCard = new NameCard();
            MyCard.SetAge(24);
            MyCard.SetName("상현");

            Console.WriteLine("나이: {0}", MyCard.GetAge());
            Console.WriteLine("이름: {0}", MyCard.GetName());
        }
*/

namespace Study._2024.Ch09_프로퍼티.코드
{
    internal class _11_ex_01
    {

        class NameCard
        {

            private int age;
            private string name;

            public int Age { get { return age; } set { age = value; } }
            public string Name { get { return name; } set { name = value; } }
        }

        static void Main11()
        {

            NameCard MyCard = new NameCard();
            MyCard.Age = 24;
            MyCard.Name = "상현";

            Console.WriteLine("나이: {0}", MyCard.Age);
            Console.WriteLine("이름: {0}", MyCard.Name);
        }
    }
}
