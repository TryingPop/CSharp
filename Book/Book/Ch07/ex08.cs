using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-8
 * 
 * 코드 중복
 */

namespace Book.Ch07
{
    internal class ex08
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

        static void Main8(string[] args)
        {
            // 비슷한 코드 중복
            List<Dog> Dogs = new List<Dog>();
            List<Cat> Cats = new List<Cat>();


            // 비슷한 코드 중복
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
