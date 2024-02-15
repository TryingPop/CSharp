using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-4
 * 
 * Animal 클래스
 */

namespace Book.Ch07
{
    internal class ex04
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
        static void Main4(string[] args)
        {
        }
    }
}
