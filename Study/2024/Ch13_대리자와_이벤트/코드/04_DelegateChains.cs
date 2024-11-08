using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 8
이름 : 배성훈
내용 : 대리자 체인
    교재 p 468 ~ 472

    대리자는 여러 개의 메소드를 동시에 참조할 수 있다.
    += 연산을 통해 결합할 수 있다.
    그리고 -= 연산을 통해 대리자를 끊어낼 수도 있다.
    아니면 Delegate.Remove()를 이용해도 된다.

    delegate는 Delegate 클래스 객체를 이용한다고 보면 된다.
*/

namespace Study._2024.Ch13_대리자와_이벤트.코드
{
    internal class _04_DelegateChains
    {

        delegate void Notify(string message);

        class Notifier
        {

            public Notify EventOccured;
        }

        class EventListener
        {

            private string name;
            public EventListener(string name)
            {

                this.name = name;
            }

            public void SomethingHappend(string message)
            {

                Console.WriteLine($"{name}.SomethingHappend : {message}");
            }
        }

        static void Main4(string[] args)
        {

            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            notifier.EventOccured += listener1.SomethingHappend;
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;

            // Listener1.SomethingHappend : You've got mail
            // Listener2.SomethingHappend : You've got mail
            // Listener3.SomethingHappend : You've got mail
            notifier.EventOccured("You've got mail");

            Console.WriteLine();

            notifier.EventOccured -= listener2.SomethingHappend;

            // Listener1.SomethingHappend : Download complete
            // Listener3.SomethingHappend : Download complete
            notifier.EventOccured("Download complete");

            Console.WriteLine();

            notifier.EventOccured = new Notify(listener2.SomethingHappend)
                + new Notify(listener3.SomethingHappend);

            // Listener2.SomethingHappend : Nuclear launch detected.
            // Listener3.SomethingHappend : Nuclear launch detected.
            notifier.EventOccured("Nuclear launch detected.");

            Console.WriteLine();

            Notify notify1 = new Notify(listener1.SomethingHappend);
            Notify notify2 = new Notify(listener2.SomethingHappend);

            notifier.EventOccured
                = (Notify)Delegate.Combine(notify1, notify2);

            // Listener1.SomethingHappend : Fire!!
            // Listener2.SomethingHappend : Fire!!
            notifier.EventOccured("Fire!!");

            Console.WriteLine();

            notifier.EventOccured =
                (Notify)Delegate.Remove(notifier.EventOccured, notify2);

            // Listener1.SomethingHappend : RPG
            notifier.EventOccured("RPG");
        }
    }
}
