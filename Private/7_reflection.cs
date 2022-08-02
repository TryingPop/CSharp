using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/* 날짜 : 22.08.01
 * 내용 : reflection
 */

namespace Private
{
    internal class _7_reflection
    {
        class Animal
        {
            public int age;
            public string name;

            public Animal(int age, string name)
            {
                this.age = age;
                this.name = name;
            }

            public void Eat()
            {
                Console.WriteLine("먹는다!");
            }

            public void Sleep()
            {
                Console.WriteLine("잔다.");
            }
        }

        class Dog : Animal, IDisposable
        {
            public string species;
            public Dog(int age, string name, string species) : base(age, name)
            {
                this.species = species;
            }

            public void Dispose()
            {
                Console.WriteLine("Dispose...");
            }
        }

        static void Main(string[] args)
        {
            // using System.Reflection;
            // 명령어가 필요하다

            Animal cat = new Animal(4, "고양이");
            // GetType : Object의 메서드
            Type type = cat.GetType();

            // 생성자 형태
            ConstructorInfo[] coninfo = type.GetConstructors();
            Console.Write("생성자(Constructor) : ");
            foreach(ConstructorInfo tmp in coninfo)
            {
                Console.Write("\t{0}", tmp);
            }
            Console.WriteLine();

            // 메서드
            MemberInfo[] meminfo = type.GetMembers();
            Console.Write("메서드(Method) : ");
            foreach(var tmp in meminfo)
            {
                Console.WriteLine($"\t{tmp}");
            }
            Console.WriteLine();


            // 속성
            FieldInfo[] fieldinfo = type.GetFields();
            Console.Write("필드(Field) : ");

            foreach(FieldInfo tmp in fieldinfo)
            {
                Console.Write($"\t{tmp}");
            }
            Console.WriteLine();

            // 이외에도 event, interface etc... 이 있다

            Console.WriteLine();
            Type type2 = typeof(Dog);
            // 특정 인터페이스가 있는지 확인하는 방법
            Type a = type2.GetInterface("IDisposable");
            Type b = type2.GetInterface("IComparable");
            Console.Write("Dog에 IDisposable 인터페이스가 있습니까? : ");
            Console.WriteLine(a is not null);

            Console.Write("Dog에 IComparable 인터페이스가 있습니까? : ");
            Console.WriteLine(b is not null);

            Type type3 = typeof(IDisposable);
            Type[] c = type3.GetNestedTypes();

            
        }
    }
}

// 참고 사이트
// https://blog.hexabrain.net/152
// https://zzangwoo.tistory.com/entry/%EB%B3%B5%EC%8A%B5-Reflection-C-%EB%A6%AC%ED%94%8C%EB%A0%89%EC%85%98
// https://nowonbun.tistory.com/488
// https://rito15.github.io/posts/memo-cs-reflection/