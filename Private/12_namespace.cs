using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForExample;
// static을 이용해 다음과 같이 이용 가능
using static ForExample.A;

/* 날짜 : 22.08.04
 * 내용 : namespace - using
 */

// Private namespace의 필드(범위안 영역) 안에 
// _01_ ... _12_ 클래스가 있고
// 각 클래스 필드에 Main? 메서드가 존재하고
// 경우에 따라 클래스가 존재한다
// 간단히 클래스와 메서드, 속성들의 집합이라 보면 될거 같다(?)
// 똑같이 _10_에 정의한 Forexample 네임스페이스 필드에는 
// Example1, Example2, Example3의 필드가 존재한다
//
// 또한 서로 다른 네임스페이스 안에 같은 이름의 클래스 명이 존재할 수도 있다.
// 그래서 (namespace이름).(클래스명)으로 불러오는데
// (using namespace이름)을 선언하면 namespace.(클래스명)으로 안불러와도 된다.
// 그리고 namespace안에서는 자신의 네임스페이스를 생략가능
namespace Private
{
    // Private안의 클래스
    internal class _12_namespace
    {
        class A 
        {
            public int num = 1;

            public void Method() { }
        }

        class B
        {
            public int num;

            public void Method()
            {
                Console.WriteLine(this.num);
            }
        }

        static void Main(string[] args)
        {
            // 위에 using ForExample를 선언해서 A를 불러오면
            // 가까운 A를 가져온다
            // 그래서 아래 A는 Private._12_namespace.A 클래스다
            A a1 = new A();
            // str 변수가 있는걸 인식 못한다
            // a1.str = "";

            // ForExample의 A를 가져오려면 다음과 같이 입력!
            ForExample.A a2 = new ForExample.A();

            // 앞에서 using 

        }
    }
}
 namespace ForExample
{
    class A
    {
        public string str;

        public void Test() { }
    }
}

// 참고 사이트
// https://m.blog.naver.com/bug_ping/221425846342