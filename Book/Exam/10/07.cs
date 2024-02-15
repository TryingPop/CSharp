

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.08.05
 * 내용 : 피보나치 연습문제
 */

namespace Exam._10
{
    internal class _10_07
    {
        interface IRunnable 
        {
            public abstract void Run();
        }

        interface IFlyable 
        { 
            public void Fly(); 
        }

        class FlyingCar : IRunnable, IFlyable
        {
            public void Run()
            {
                Console.WriteLine("Car Run!");
            }

            public void Fly()
            {
                Console.WriteLine("Car Fly!");
            }
        }
        static void Main7(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runable = car as IRunnable;
            IFlyable flyable = car as IFlyable;

            runable.Run();
            flyable.Fly();
        }
    }
}
