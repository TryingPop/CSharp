using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-13
 * 
 * Object 클래스의 다형성 예제(2)
 */

namespace Book.Ch07
{
    internal class ex13
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

        static void Main13(string[] args)
        {
            List<Object> listOfObject = new List<Object>();
            listOfObject.Add(new Dog());
            listOfObject.Add(new Cat());

            listOfObject.Add(52);
            listOfObject.Add(52L);
            listOfObject.Add(52.273f);
            listOfObject.Add(52.273d);

            foreach (Object item in listOfObject)
            {
                Console.WriteLine(item);
            }
        }
    }
}
