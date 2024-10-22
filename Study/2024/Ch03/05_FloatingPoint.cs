using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 22
이름 : 배성훈
내용 : FloatingPoint
    교재 p 56 ~ 59

    부동 소숫점에 관련된 내용이 있다
    float은 7개의 자릿수만 다룰 수 있다 한다
    double은 15 ~ 16개의 자릿수를 다룰 수 있다 한다

    float는 1비트를 부호 전용, 가수부 23비트를 수를 표현하는데 사용한다
    그리고 나머지 지수부 8비트를 소수점의 위치를 나타내기 위해 사용한다고 한다

    float은 넓은 범위를 수를 다룰 수 있다
    +-3.402823e38 (e38은 10^38)

    실수 자료형은 데이터 손실이 최소화되어야 해서
    float보다는 double이 좋다 더 정밀하게 해야한다면 decimal를 이용해야한다
*/

namespace Study._2024.Ch03
{
    internal class _05_FloatingPoint
    {

        static void Main5(string[] args)
        {

            float a = 3.1415_9265_3589_7932_3846f;
            Console.WriteLine(a);   // 3.1415927

            double b = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b);   // 3.141_592_653_589_793
        }
    }
}
