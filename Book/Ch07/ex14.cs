using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-14
 * 
 * is 키워드
 */

namespace Book.Ch07
{
    internal class ex14
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

        static void Main14(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                // 원소의 포함된 클래스를 판별할 때 is 를 사용
                // 현재 클래스 + 부모들의 클래스 모두 판별할 때 이용가능하다
                // 여기에 포함된 클래스는 캐스팅 가능
                if (item is Dog) { Console.WriteLine("Dog"); }
                if (item is Cat) { Console.WriteLine("Cat"); }
                if (item is Animal) { Console.WriteLine("Animal"); }
                if (item is Object) { Console.WriteLine(item is Object); }
            }
            
            // animal로 참조되어서 사용 불가능
            // Animals[0].Bark();
        }
    }
}
