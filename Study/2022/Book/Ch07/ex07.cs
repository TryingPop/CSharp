using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.25
 * 내용 : 코드 7-7
 * 
 * 세 가지 접근 제한자
 */

namespace Book.Ch07
{
    internal class ex07
    {
        class Animal
        {
            private void Private() { }
            protected void Protected() { }
            public void Public() { }

            public void TestA()
            {
                this.Private();
                this.Protected();
                this.Public();
            }
        }

        class Dog : Animal
        {
            public void TestB()
            {
                this.Protected();
                this.Public();
                // base.Private(); // 접근 불가능하다
            }
        }

        static void Main6(string[] args)
        {
            Dog dog = new Dog();
            dog.Public();
            // dog.Protected(); // 접근 불가능하다
            // dog.Private(); // 접근 불가능하다
        }
    }
}
