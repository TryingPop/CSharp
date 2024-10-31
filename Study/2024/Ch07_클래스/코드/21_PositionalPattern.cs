using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

/*
날짜 : 2024. 10. 31
이름 : 배성훈
내용 : 튜플
    교재 p 290 ~ 292

    튜플이 분해가 가능한 이유는 분해자 Deconstructor을 구현하고 있기 때문이다.
    분해자를 구현하고 있는 객체를 분해한 결과 switch 문이나 switch 식에서 사용할 수 있다.

    이를 패턴 매칭(Positional Pattern Matching) 이라고 한다.
*/

namespace Study._2024.Ch07_클래스.코드
{
    internal class _21_PositionalPattern
    {

        public static double GetDiscountRate(object client)
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

        static void Main21(string[] args)
        {

            var alice = (job: "학생", age: 17);
            var bob = (job: "학생", age: 23);
            var charlie = (job: "일반", age: 15);
            var dave = (job: "일반", age: 21);

            Console.WriteLine($"alice   : {GetDiscountRate(alice)}");   // 0.2
            Console.WriteLine($"bob     : {GetDiscountRate(bob)}");     // 0.1
            Console.WriteLine($"charlie : {GetDiscountRate(charlie)}"); // 0.1
            Console.WriteLine($"dave    : {GetDiscountRate(dave)}");    // 0.05
        }
    }
}
