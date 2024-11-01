using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : with를 이용한 레코드 복사
    교재 p 340 ~ 341

    C# 컴파일러는 레코드 형식을 위한 복사 생성자를 자동으로 작성한다.
    복사 생성자는 protected로 선언되기 때문에 명시적으로 호출할 수 없고
    with 식을 이용해 호출할 수 있다.
*/

namespace Study._2024.Ch09_프로퍼티.코드
{
    internal class _06_WithExp
    {

        record RTransaction
        {

            public string From { get; init; }
            public string To { get; init; }
            public int Amount { get; init; }

            public int B = 200;

            public override string ToString()
            {

                return $"{From,-10} -> {To,-10} : ${Amount}";
            }
        }

        static void Main6(string[] args)
        {

            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = tr1 with { To = "Charlie" };
            RTransaction tr3 = tr2 with { From = "Dave", Amount = 30 };

            // Alice      -> Bob        : $100
            Console.WriteLine(tr1);

            // Alice      -> Charlie    : $100
            Console.WriteLine(tr2);

            // Dave       -> Charlie    : $30
            Console.WriteLine(tr3);
        }
    }
}
