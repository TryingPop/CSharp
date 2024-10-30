using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 객체의 삶과 죽음 : 생성자와 종료자
    교재 p 226 ~ 231

    생성자와 종료자에 대해 설명하고 있다
    종료자는 가비지 컬렉터에 맡기는게 좋다고 해서 정의안하는게 좋다고 한다
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _02_Constructor
    {

        class Cat
        {

            public Cat()
            {

                Name = "";
                Color = "";
            }

            public Cat(string _Name, string _Color)
            {

                Name = _Name;
                Color = _Color;
            }

            ~Cat()
            {

                Console.WriteLine($"{Name}: 잘가");
            }

            public string Name;
            public string Color;

            public void Meow()
            {

                Console.WriteLine($"{Name}: 야옹");
            }
        }

        static void Main2(string[] args)
        {

            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.Name}: {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name}: {nero.Color}");
        }
    }
}
