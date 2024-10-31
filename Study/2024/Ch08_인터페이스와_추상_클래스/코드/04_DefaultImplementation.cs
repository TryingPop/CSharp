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
        
        static void Main(string[] args)
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
