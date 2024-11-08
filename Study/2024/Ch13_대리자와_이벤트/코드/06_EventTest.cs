using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 8
이름 : 배성훈
내용 : 이벤트
    교재 p 476 ~ 481

    어떤 일이 생겼을 때 이를 알려주는 객체가 필요한 경우가 있다.
    이런 객체를 만들 때 사용하는 것이 바로 이벤트(Event)이다.
    동작은 대리자와 거의 비슷하다.

    이벤트는 대리자를 event 한정자로 수시갷서 만들 뿐이다.
    대리자를 선언하고 클래스 내에 event 한정자로 수식해서 선언한다.
    이벤트 핸들러를 작성한다. 이 때 대리자와 일치하는 메소드면 된다.
    클래스 인스턴스를 생성하고 이벤트에서 작성한 이벤트 핸들러를 등록한다.
    이벤트가 발생하면 이벤트 핸들러가 호출된다.

    이벤트는 외부에서 직접 사용할 수 없다.
    이벤트가 public 한정자로 선언되어 있어도 자신이 선언된 클래스 외부에서는 호출이 불가능하다.
    반면 대리자는 외부에서라도 얼마든지 호출이 가능하다.

    이벤트를 객체 외부에서 임의로 호출할 수 있게 된다면 외부에서 허위로 상태변화 이벤트를 일으킬 수 있게 된다.
    이는 허위 상태 전달으로 객체의 상태를 바꾸는것보다 더 위험한 상황을 초래할 수 있다.
*/

namespace Study._2024.Ch13_대리자와_이벤트.코드
{
    internal class _06_EventTest
    {

        delegate void EventHandler(string message);

        class MyNotifier
        {

            public event EventHandler SomethingHappended;
            public void DoSomething(int number)
            {

                int temp = number % 10;

                if (temp != 0 && temp % 3 == 0)
                {

                    SomethingHappended(String.Format("{0} : 짝", number));
                }
            }

            static public void MyHandler(string message)
            {

                Console.WriteLine(message);
            }

            static void Main6(string[] args)
            {

                MyNotifier notifier = new MyNotifier();
                notifier.SomethingHappended += new EventHandler(MyHandler);

                for (int i = 1; i < 30; i++)
                {

                    notifier.DoSomething(i);
                }
            }
        }
    }
}
