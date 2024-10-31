using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 연습문제 5
    교재 p 293

    다음 코드를 컴파일 및 실행이 가능하도록 수정하세요.

        using System;

        struct ACSetting
        {

            public double currentInCelsius; // 현재 온도
            public double target;           // 희망 온도

            public readonly double GetFahrenheit()
            {

                target = currentInCelsius * 1.8 + 32;       // 화씨 계산 결과
                return target;
            }
        }

        static void Main(string[] args)
        {

            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }

    실행 결과
        77
        25


    double을 추가해 target 지역변수에 넣어주면 된다
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _26_ex_05
    {

        struct ACSetting
        {

            public double currentInCelsius; // 현재 온도
            public double target;           // 희망 온도

            public readonly double GetFahrenheit()
            {

                double target = currentInCelsius * 1.8 + 32;       // 화씨 계산 결과
                return target;
            }
        }

        static void Main26(string[] args)
        {

            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}
