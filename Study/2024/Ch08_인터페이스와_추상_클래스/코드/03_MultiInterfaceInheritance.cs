using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 여러 개의 인터페이스, 한꺼번에 상속하기
    교재 p 308 ~ 312

    클래스는 여러 클래스를 한꺼번에 상속할 수 없다.
    다중 상속을 허용하면 중복 메소드가 존재하면 어떤것을 상속받아야할지 모호해지기 때문이다.
    인터페이스는 다중상속을 지원하는데 인터페이스는 내용이 아닌 외형을 물려주기 때문에 그렇다.

    다른 클래스를 여러개 물려받고 싶을 때는 포함(Containment)이라는 기법도 있다.
    이는 상속받고 싶은 기능을 가진 클래스들을 필드로 선언하는 것이다.
*/

namespace Study._2024.Ch08_인터페이스와_추상_클래스.코드
{
    internal class _03_MultiInterfaceInheritance
    {

        interface IRunnable
        {

            void Run();
        }

        interface IFlyable
        {

            void Fly();
        }

        class FlyingCar : IRunnable, IFlyable
        {

            public void Run()
            {

                Console.WriteLine("Run! Run!");
            }

            public void Fly()
            {

                Console.WriteLine("Fly! Fly!");
            }
        }

        static void Main3(string[] args)
        {

            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}
