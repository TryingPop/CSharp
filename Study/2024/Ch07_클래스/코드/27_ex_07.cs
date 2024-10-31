using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 연습문제 7
    교재 p 295

    다음 코드에서 switch 식을 제거하고 switch 문으로 동일한 기능을 작성하세요.

        private static double GetDiscountRate(object client)
        {

            return client switch
            {

                ("학생", int n) when n < 18 => 0.2,
                ("학생", _) => 0.1,
                ("일반", int n) when n < 18 => 0.1,
                ("일반", _) => 0.05,
                _ => 0,
            };
        }
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _27_ex_07
    {

        private static double GetDiscountRate(object client)
        {

            switch (client)
            {

                case ("학생", int n) when n < 18:
                    return 0.2;

                case ("학생", _):
                    return 0.1;

                case ("일반", int n) when n < 18:
                    return 0.1;

                case ("일반", _):
                    return 0.05;

                default:
                    return 0;
            }
        }
    }
}
