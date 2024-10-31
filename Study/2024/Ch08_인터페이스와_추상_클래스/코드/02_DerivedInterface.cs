using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 인터페이스를 상속하는 인터페이스
    교재 p 306 ~ 308

    인터페이스를 상속할 수 있는건 클래스뿐 아니라 구조체는 물론이고 인터페이스도 상속할 수 있다.
    인터페이스에 새로운 기능을 추가한 인터페이스를 만들고 싶을 때 인터페이스를 상속하는 인터페이스를 만들면 된다.

    인터페이스를 수정해도 상관없지만 수정못하는 경우 상속한다.
    수정 못하는 인터페이스는 .NET SDK에서 제공하는 인터페이스들이 대표적인 예이다

    상속하는 클래스들이 다수 존재하는 경우 모두 수정할 수 있다.
*/

namespace Study._2024.Ch08_인터페이스와_추상_클래스.코드
{
    internal class _02_DerivedInterface
    {

        interface ILogger
        {

            void WriteLog(string message);
        }

        interface IFormattableLogger: ILogger
        {

            void WriteLog(string format, params object[] args);
        }

        class ConsoleLogger2: IFormattableLogger
        {

            public void WriteLog(string message)
            {

                Console.WriteLine("{0} {1}",
                    DateTime.Now.ToLocalTime(), message);
            }

            public void WriteLog(string format, params object[] args)
            {

                string message = string.Format(format, args);
                Console.WriteLine("{0} {1}",
                    DateTime.Now.ToLocalTime(), message);
            }
        }

        static void Main2(string[] args)
        {

            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The world is not flat");           // The world is not flat
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);        // 1 + 1 = 2
        }
    }
}
