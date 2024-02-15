using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-10
 * 
 * 무작정 변환해서 메서드 호출
 */

namespace Book.Ch07
{
    internal class ex10
    {
        class Animal
        {
            public int Age
            {
                get;
                set;
            }

            public Animal()
            {
                this.Age = 0;
            }

            public void Eat()
            {
                Console.WriteLine("냠냠 먹습니다.");
            }

            public void Sleep()
            {
                Console.WriteLine("쿨쿨 잠을 잡니다.");
            }
        }

        class Dog : Animal
        {
            public string Color { get; set; }

            public void Bark()
            {
                Console.WriteLine("왈왈 짖습니다.");
            }
        }

        class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine("냥냥 웁니다.");
            }
        }

        static void Main10(string[] args)
        {
            // 비슷한 코드 중복
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat()
            };

            foreach (Animal item in Animals)
            {
                item.Eat();
                item.Sleep();
                // ((Cat)item).Meow();
                // Dog를 Cat으로 캐스팅 불가능
            }
            // Animals[0].Bark();
            // Animal 클래스에 없는 메서드나 속성은 활용 못한다
        }
    }
}
