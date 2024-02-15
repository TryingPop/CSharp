using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-3
 * 
 * Dog와 Cat 클래스의 인스턴스를 만들고 메서드 실행
 */

namespace Book.Ch07
{
    internal class ex03
    {
        class Dog
        {
            public int Age { get; set; }
            public string Color { get; set; }

            public Dog()
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

            public void Bark()
            {
                Console.WriteLine("왈왈 짓습니다.");
            }
        }

        class Cat
        {
            public int Age { get; set; }

            public Cat() 
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

            public void Meow()
            {
                Console.WriteLine("냥냥 웁니다.");
            }
        }
        static void Main3(string[] args)
        {
            List<ex03.Dog> Dogs = new List<ex03.Dog>() { new Dog(), new Dog(), new Dog()};
            List<ex03.Cat> Cats = new List<ex03.Cat>() { new Cat(), new Cat(), new Cat()};

            foreach (Dog item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
            }

            foreach (Cat item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
            }
        }
    }
}
