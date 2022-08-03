#define Test

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.08.01
 * 내용 : 특성(attribute) - 
 */

namespace Private
{

    // 기본적인 형태 : [attribute명(positional_parameter, name_parameter = value, ...)]
    internal class _06_attribute
    {
        static void Main6(string[] args)
        {
            // string Test = ""; // 이를 정의해도 위에 #define Test가 없으면 작동하지 않는다.
            TestMethod();

            OldMethod();

            MessageBox(0, "DllImport!", "DllImport", 3);

            CustomAttribute.Say();
            CustomAttribute.ShowMetaData();

            _06_attribute a = new _06_attribute();

            // 메소드들의 집합
            var methods = typeof(_06_attribute).GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).ToList();      
            
            // 반복문으로 데이터 추출
            foreach (var method in methods)     
            {        
                // 메소드에서 ExampleAttribute의 어트리뷰트를 취득
                var attribute = method.GetCustomAttribute(typeof(ExampleAttribute)) as ExampleAttribute;        
                // Example어트리뷰트가 있으면 - 즉, Print4는 제외
                if (attribute != null)        
                {   
                    // ExampleAttribute에서 Test이름을 가진 어트리뷰트 메서드 확인
                    // print1, print2 가 해당
                    if (string.Equals(attribute.Name, "Test"))          
                    {   
                        // null : parameters
                        method.Invoke(a, null); 
                    }

                    // ExampleAttribute에서 attribute Message가 Hello World!인 것을 확인
                    // print2가 해당
                    if (string.Equals(attribute.Message, "Hello World!"))
                    {
                        method.Invoke(a, null);
                    }

                    if (string.Equals(attribute.Name, "Test1"))
                    {
                        method.Invoke(a, null);
                    }
                }      
            }
        }
        // #define Test가있어야 사용 가능한 메서드
        // Conditional은 메서드 위에서만 사용한다
        [Conditional("Test")]
        public static void TestMethod()
        {
            Console.WriteLine("Test Conditional!");
        }

        // 경고 문구를 표현해주는 어트리뷰트
        // 2번째 매개변수에 true를 입력하면 에러가 뜬다
        
        [Obsolete("OldMethod()는 더이상 사용 안하므로, NewMethod()를 사용해주세요.")]
        // [Obsolete("OldMethod()는 더이상 사용 안하므로, NewMethod()를 사용해주세요.", true)]
        public static void OldMethod() { Console.WriteLine("Old"); }
        public static void NewMethod() { Console.WriteLine("New"); }


        // User32.dll에 정의되어져 있는 함수를 불러와서 사용
        // 외부 dll에 정의 되어져 있기에 extern 지정자를 붙인다
        [DllImport("User32.dll")]
        public static extern int MessageBox(int hParent, string Message, string Caption, int Type);

        // 비트 연산자
        // 메서드, 프로퍼티, 클래스에 사용가능, 어트리뷰트 복수 사용 가능
        [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Class, AllowMultiple = true)]
        public class AuthorAttribute : Attribute 
        {
            public string name;

            // 생성자
            public AuthorAttribute(string name) 
            { 
                this.name = name; 
            }
        }

        // 클래스에 사용
        [AuthorAttribute("Exam")]
        class CustomAttribute
        {
            public static void Say()
            {
                Console.WriteLine("Hello");
            }

            public static void ShowMetaData()
            {
                Attribute[] attrs = Attribute.GetCustomAttributes(typeof(CustomAttribute));

                foreach (Attribute attr in attrs)
                {
                    AuthorAttribute aa = attr as AuthorAttribute;
                    if (aa != null)
                    {
                        Console.WriteLine(aa.name);
                    }
                }
            }
        }

        [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
        class ExampleAttribute : Attribute
        {
            public string Name { get; set; }
            public string Message { get; set; }

            public ExampleAttribute(string name)
            {
                this.Name = name;
            }
        }


        [ExampleAttribute("Test")]
        public void Print1()
        {
            Console.WriteLine("Print1...");
        }

        [ExampleAttribute("Test", Message = "Hello World!")]
        public void Print2()
        {
            Console.WriteLine("Print2...");
        }

        [ExampleAttribute("Test1")]
        public void Print3()
        {
            Console.WriteLine("Print3...");
        }
    }
}


// 참고 사이트
// https://godffs.tistory.com/211?category=111217
// https://nowonbun.tistory.com/128

// 생성자는 필수가 아니나 생성자를 작성하면 매개변수는 필수

// 주석은 사라지는 반면 컴파일러는 남아있는다
// 컴파일러한테 알려주는 역할
// 웹프로그래밍 문법
// python의 decorate와 차이점 참고하기!
