using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.08.01
 * 내용 : typeof, GetType 의 차이점
 */

namespace Private
{
    internal class _09_typeof__GetType
    {
        static void Main9(string[] args)
        {
            // 클래스 자체의 타입을 가져온다
            Type type = typeof(int);
            Console.WriteLine(type.Name);

            // GetType은 Object의 인스턴스 함수
            // 런타임시 생성되는 인스턴스의 타입을 가져온다
            int a = 0;
            Console.WriteLine(a.GetType());

            Animal dog = new Dog();
            // true
            Console.WriteLine(dog is Animal);
            Console.WriteLine(dog is Dog);
            Console.WriteLine(dog.GetType() == typeof(Dog));
            
            // false
            // 함수의 인자가 Animal이라도 dog는 Dog의 인스턴스라 다르다
            Console.WriteLine(dog.GetType() == typeof(Animal));
        }

        class Animal { }

        class Dog : Animal { }
    }
}

// 참고 사이트
// https://guslabview.tistory.com/270