using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 오버라이딩과 다형성
    교재 p 260 ~ 264

    객체지향 프로그래밍에서는 다형성(Polymorphism)은 객체가 여러 형태를 가질수 있음을 의미한다.
    다형성은 하위 형식 다형성(Subtype polymorphism)의 준말이다.
    자신으로부터 상속받아 만들어진 파생 클래스를 통해 다형성을 실현 한다는 뜻이다.

    다형성을 하기위해서는 메소드를 재정의해줘야한다.
    즉, 오버라이딩(Overriding)을 해줘야 한다.

    오버라이딩을 하기 위해서는 메소드가 virtual 키워드로 한정되어 있어야 한다.
    그리고 접근 한정자가 private으로 선언하면 파생클래스에서 보이지 않으므로 오버라이딩 할 수 없다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _10_Overriding
    {

        class ArmorSuite
        {

            public virtual void Initialize()
            {

                Console.WriteLine("Armored");
            }
        }

        class IronMan : ArmorSuite
        {

            public override void Initialize()
            {

                base.Initialize();
                Console.WriteLine("Repulsor Rays Armed");
            }
        }

        class WarMachine : ArmorSuite
        {

            public override void Initialize()
            {

                base.Initialize();
                Console.WriteLine("Double-Barrel Cannons Armed");
                Console.WriteLine("Micro-Rocket Launcher Armed");
            }
        }

        static void Main10(string[] args)
        {

            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();    // Armored

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();       // Armored
                                        // Repulsor Rays Armed

            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();    // Armored
                                        // Double-Barrel Cannons Armed                
                                        // Micro-Rocket Launcher Armed
        }                       
    }
}
