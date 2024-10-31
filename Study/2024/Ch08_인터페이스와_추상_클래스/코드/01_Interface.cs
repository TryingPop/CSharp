using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 인터페이스
    교재 p 299 ~ 305

    인터페이스는 interface 키워드를 이용해 선언한다.
    인터페이스는 메소드, 이벤트, 인덱서, 프로퍼티만을 가질 수 있따는 차이가 있다.

    클래스는 접근한정자로 수식하지 않으면 기본적으로 private선언이지만 
    인터페이스는 접근 제한 한정자를 사용하라 수 없고 public으로 선언된다.

    인터페이스는 상속받는 클래스를 이용해서만 인스턴스를 만들 수 있다.

    인터페이스는 클래스가 따라야 하는 약속이다.
    이 약속은 인터페이스로부터 파생될 클래스가 어떤 메소드를 구현해야할 지를 정의하는 것이다.
*/

namespace Study._2024.Ch08_인터페이스와_추상_클래스.코드
{
    internal class _01_Interface
    {

        interface ILogger
        {

            void WriteLog(string message);
        }

        class ConsoleLogger: ILogger
        {

            public void WriteLog(string message)
            {

                Console.WriteLine("{0} {1}",
                    DateTime.Now.ToLocalTime(), message);
            }
        }

        class FileLogger: ILogger
        {

            private StreamWriter writer;

            public FileLogger(string path)
            {

                // 해당 프로젝트의 bin 폴더 -> Debug -> net6.0(현재 버전) 폴더 안에
                // MyLog.txt 파일이 생성된다
                writer = File.CreateText(path);
                writer.AutoFlush = true;
            }

            public void WriteLog(string message)
            {

                writer.WriteLine("{0} {1}",
                    DateTime.Now.ToShortTimeString(), message);
            }
        }

        class ClimateMonitor
        {

            private ILogger logger;
            public ClimateMonitor(ILogger logger)
            {

                this.logger = logger;
            }

            public void Start()
            {

                while (true)
                {

                    Console.Write("온도를 입력해주세요.: ");
                    string temperature = Console.ReadLine();
                    if (temperature == "")
                        break;

                    logger.WriteLog("현재 온도: " + temperature);
                }
            }
        }

        static void Main1(string[] args)
        {

            ClimateMonitor monitor = new ClimateMonitor(
                new FileLogger("MyLog.txt"));

            monitor.Start();
        }
    }
}
