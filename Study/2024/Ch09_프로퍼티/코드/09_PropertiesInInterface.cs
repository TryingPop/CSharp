using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 인터페이스의 프로퍼티
    교재 p 346 ~ 349

    인터페이스는 프로퍼티 뿐 아니라 인덱서도 가질 수 있다.
    인터페이스에서 프로퍼티는 구현을 갖지 않는다.
    그래서 자동 구형 프로퍼티 선언과 모습이 동일하다.
*/

namespace Study._2024.Ch09_프로퍼티.코드
{
    internal class _09_PropertiesInInterface
    {

        interface INamedValue
        {

            string Name { get; set; }

            string Value { get; set; }
        }

        class NamedValue: INamedValue
        {

            public string Name { get; set; }
            public string Value { get; set; }
        }

        static void Main9(string[] args)
        {

            NamedValue name = new NamedValue() { Name = "이름", Value = "박상현" };
            NamedValue height = new NamedValue() { Name = "키", Value = "177cm" };
            NamedValue weight = new NamedValue() { Name = "몸무게", Value = "90kg" };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");
        }
    }
}
