using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 연습문제 3
    교재 p217 ~ 218

    다음 코드에 Plus() 메소드가 double 형 매개변수를 지원하도록 오버로딩 하세요.
    이 프로그램이 완성된 후의 실행 결과는 다음과 같아야 합니다.

        3 + 4 = 7
        2.4 + 3.1 = 5.5

    코드
        using System;

        public static void Main()
        {


            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);        // 오버로드가 필요한 메소드입니다.

            Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
        }

        public static void Plus(int a, int b, out int c)
        {

            c = a + b;
        }

        // 이 아래에 double 형 매개변수를 받을 수 있도록
        // 오버로딩된 Plus() 메소드를 작성하세요
*/

namespace Study._2024.Ch06_메소드.코드
{
    internal class _14_ex_03
    {

        public static void Main14()
        {


            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);        // 오버로드가 필요한 메소드입니다.

            Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
        }

        public static void Plus(int a, int b, out int c)
        {

            c = a + b;
        }

        public static void Plus(double a, double b, out double c)
        {

            c = a + b;
        }
    }
}
