using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-1
 * 
 * Dog 클래스
 */

namespace Book.Ch07
{
    internal class ex01
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
        static void Main1(string[] args)
        {
        }
    }
}
