using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 객체지향 프로그래밍과 클래스
    교재 p 221 ~ 226

    객체지향 프로그래밍과 객체에 대한 설명이 있다
    그리고 클래스와 클래스에 대한 설명이 있다

    
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _01_BasicClass
    {

        class Cat
        {

            public string Name;
            public string Color;

            public void Meow()
            {

                Console.WriteLine($"{Name} : 야옹");
            }
        }

        static void Main1(string[] args)
        {

            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";

            kitty.Meow();                                       // 키티 : 야옹
            Console.WriteLine($"{kitty.Name} : {kitty.Color}"); // 키티 : 하얀색

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";

            nero.Meow();                                        // 네로 : 야옹
            Console.WriteLine($"{nero.Name} : {nero.Color}");   // 네로 : 검은색
        }
    }
}
