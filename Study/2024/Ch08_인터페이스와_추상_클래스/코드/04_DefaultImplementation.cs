using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 인터페이스 기본 구현 메소드
    교재 p 312 ~ 315

    인터페이스가 선언하는 메소드는 파생될 클래스가 무엇을 구현해야 할지를 정의하는 역할만 하면 됐기 때문이다.<br/>
    기본 구현 메소드는 이름처럼 구현부를 갖는 메소드인데 인터페이스의 다른 메소드와 역할이 다른다.

    새로운 함수가 추가할 때 컴파일에러를 피해갈 수 있다.
    인터페이스 참조로 업캐스팅 했을 대만 사용할 수 있다.
*/

namespace Study._2024.Ch08_인터페이스와_추상_클래스.코드
{
    internal class _04_DefaultImplementation
    {

        interface ILogger
        {

            void WriteLog(string message);

            void WriteError(string error)   // 새로운 메소드 추가
            {

                WriteLog($"Error: {error}");
            }
        }

        class ConsoleLogger: ILogger
        {

            public void WriteLog(string message)
            {

                Console.WriteLine(
                    $"{DateTime.Now.ToLocalTime()}, {message}");
            }
        }
        
        static void Main4(string[] args)
        {

            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up");
            // clogger.WriteError("System Fail");   // 컴파일 에러
        }
    }
}
