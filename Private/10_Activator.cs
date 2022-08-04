using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ForExample;

/* 날짜 : 22.08.03
 * 내용 : Activator - CreateInstance 메서드
 */

namespace ForExample
{
    class Example1
    {
        public int num;
        public string str;

        public void Test1() { }
        public void Test2() { }

        public override string ToString()
        {
            return $"str : {this.str},\tnum : {this.num}";
        }
    }

    class Example2
    {
        public int num;
        public string str;

        public Example2(int num, string str)
        {
            this.num = num;
            this.str = str;
        }

        public void Test1() { }
        public void Test2() { }

        public override string ToString()
        {
            return $"str : {this.str},\tnum : {this.num}";
        }
    }

    class Example3
    {
        private int num;
        public string str;

        private Example3(int num, string str)
        {
            this.num = num;
            this.str = str;
        }

        public void Test1() { }
        public void Test2() { }

        public override string ToString()
        {
            return $"str : {this.str},\tnum : {this.num}";
        }
    }
}

namespace Private
{
    internal class _10_Activator
    {
        static void Main10(string[] args)
        {
            var obj1 = (Example1)Activator.CreateInstance(typeof(Example1));
            obj1.str = "문자";
            Console.WriteLine(obj1);

            // 매개변수가 잇는경우
            Object[] param = new Object[] {1, "문자1"};
            var obj2 = (Example2)Activator.CreateInstance(typeof(Example2), param);
            Console.WriteLine(obj2);
            // 혹은
            var obj3 = (Example2)Activator.CreateInstance(typeof(Example2), 4, "문자4");
            Console.WriteLine(obj3);

            // 생성자가 private로 감춰져 있는 경우
            // BindingFlag를 활용!
            var obj4 = (Example3)Activator.CreateInstance(typeof(Example3), BindingFlags.Instance | BindingFlags.NonPublic, null, new object[] { 5, "문자5" }, null);
            Console.WriteLine(obj4);

            Assembly assem = typeof(Example1).Assembly;
            Console.WriteLine(assem.GetName());
            string assemname = assem.FullName;
            // var obj5 = (Example2)Activator.CreateInstance(assemname, "Example2", 13, "문자13");
            // Console.WriteLine(obj5);


            // Assembly.CreateInstance 메서드
            // 매개변수가 없을 때
            var obj6 = assem.CreateInstance("ForExample.Example1");
            Console.WriteLine("obj6가 null? : {0}", obj6 == null);
            Console.WriteLine(obj6);

            
            // 매개변수가 있는 경우
            // type이 아닌 string으로 클래스 가져오기
            var type = typeof(Example2).Assembly.GetType();
            var obj7 = assem.CreateInstance("ForExample.Example2", 
                                            true, 
                                            BindingFlags.Instance | BindingFlags.Public,
                                            null, 
                                            new object[] { 17, "문자17" },
                                            System.Globalization.CultureInfo.CurrentCulture, 
                                            null) as Example2;
            Console.WriteLine("obj7가 null? : {0}", obj7 == null);
            Console.WriteLine(obj7);
        }
    }
}

// 참고 사이트
// https://velog.io/@opzerg/20-0503-%EC%9B%90%EA%B2%A9%EC%9C%BC%EB%A1%9C-%EA%B0%9C%EC%B2%B4%EC%83%9D%EC%84%B1%ED%95%98%EA%B8%B0

// 동적의 경우 
// 힙 영역에 생성되고 런타임 중에 생성
// 
// 정적 생성하는 경우
// 스택 영역에 생성(static)
// 컴파일러가 미리 공간을 예측할 수 있다.

// 어셈블리의 뜻
// http://daplus.net/c-net-%EC%96%B4%EC%85%88%EB%B8%94%EB%A6%AC-%EB%9E%80-%EB%AC%B4%EC%97%87%EC%9E%85%EB%8B%88%EA%B9%8C/

// 다른 프로젝트의 클래스 이용
// https://yeko90.tistory.com/entry/c-%EA%B8%B0%EC%B4%88-%EB%8B%A4%EB%A5%B8-%ED%94%84%EB%A1%9C%EC%A0%9D%ED%8A%B8%EC%97%90-%EC%9E%88%EB%8A%94-%ED%81%B4%EB%9E%98%EC%8A%A4-%ED%95%A8%EC%88%98-%EC%82%AC%EC%9A%A9%ED%95%98%EB%8A%94%EB%B2%95
