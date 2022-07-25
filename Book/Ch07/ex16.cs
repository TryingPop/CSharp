using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-16
 * 
 * as 키워드를 사용한 자료형 변환
 */

namespace Book.Ch07
{
    internal class ex16
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

        static void Main16(string[] args)
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
                
                // cast는 변환 불가능하면 오류문구가 뜨는 반면
                // as는 변환 불가능 하면 Null 값으로 대체된다
                if (item is Dog) { (item as Dog).Bark(); }
                if (item is Cat) { (item as Cat).Meow(); }
            }
        }
    }
}
