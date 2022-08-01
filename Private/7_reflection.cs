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

        static void Main7(string[] args)
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
        }
    }
}

// 참고 사이트
// https://blog.hexabrain.net/152