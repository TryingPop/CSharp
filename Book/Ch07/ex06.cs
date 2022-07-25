using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-6
 * 
 * 부모에게서 상속받은 메서드 호출
 */

namespace Book.Ch07
{
    internal class ex06
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
                Console.WriteLine("왈왈 짖습니다");
            }

            public void Test()
            {
                base.Eat();
                base.Sleep();
            }
        }

        static void Main6(string[] args)
        {

        }
    }
}
