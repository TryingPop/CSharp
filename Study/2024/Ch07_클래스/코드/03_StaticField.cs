using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 정적 필드와 메소드
    교재 p231 ~ 234

    static은 사전적으로는 정적이라는 뜻을 갖고 있다.
    움직이지 않는다는 뜻이다.

    C#에서 static은 메소드나 필드가 클래스의 인스턴스가 아닌 
    클래스 자체에 소속되도록 지정하는 한정자이다.

    static으로 한정하지 않은 필드는 자동으로 인스턴스에 소속되며,
    static으로 한정한 필드는 클래스에 소속된다.

    static으로 수식한 필드는 프로그램 전체에 걸쳐 공유해야 하는 변수인 경우에
    사용하는 것이 좋다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _03_StaticField
    {

        class Global
        {

            public static int Count = 0;
        }

        class ClassA
        {

            public ClassA()
            {

                Global.Count++;
            }
        }

        class ClassB
        {

            public ClassB()
            {

                Global.Count++;
            }
        }

        static void Main3(string[] args)
        {

            Console.WriteLine($"Global.Count: {Global.Count}"); // 0

            new ClassA();
            new ClassA();
            new ClassB();

            Console.WriteLine($"Global.Count: {Global.Count}"); // 3
        }
    }
}
