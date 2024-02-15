using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-28
 * 
 * 하이딩
 */

namespace Book.Ch07
{
    internal class ex28
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("냠냠 먹습니다.");
            }
        }

        class Dog : Animal
        {
            public void Eat()
            {
                Console.WriteLine("강아지 사료를 먹습니다.");
            }
        }

        class Cat : Animal
        {
            public void Eat()
            {
                Console.WriteLine("고양이 사료를 먹습니다.");
            }
        }

        static void Main28(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat()
            };

            foreach (Animal item  in Animals)
            {
                item.Eat(); // new로 메서드를 하이딩했고,
                            // item의 타입이 부모 타입으로 형변환 되었으므로
                            // 부모 클래스의 Eat 메서드가 실행된다
            }
        }
    }
}
