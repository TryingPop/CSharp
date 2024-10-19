using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-2
 * 
 * Cat 클래스
 */

namespace Book.Ch07
{
    internal class ex02
    {
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
        static void Main2(string[] args)
        {
        }
    }
}
