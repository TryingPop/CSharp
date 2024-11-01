using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 레코드 객체 비교하기
    교재 p 341 ~ 344

    클래스의 내부 필드가 같은지 확인하려면 Equals 메소드를 오버라이딩 하고 내부 필드를 비교해야 한다.
    하지만 record는 구현하지 않아도 내부 필드를 비교를 알아서 지원해준다
*/

namespace Study._2024.Ch09_프로퍼티.코드
{
    internal class _07_RecordComp
    {

        class CTransaction
        {

            public string From { get; init; }
            public string To { get; init; }
            public int Amount { get; init; }

            public override string ToString()
            {

                return $"{From,-10} -> {To,-10} : ${Amount}";
            }

            /*
            public override bool Equals(object obj)
            {

                CTransaction target = obj as CTransaction;

                if (target != null
                    && this.From == target.From
                    && this.To == target.To
                    && this.Amount == target.Amount) return true;
                else return false;
            }
            */
        }

        record RTransaction
        {

            public string From { get; init; }
            public string To { get; init; }
            public int Amount { get; init; }

            public override string ToString()
            {

                return $"{From,-10} -> {To,-10} : ${Amount}";
            }
        }

        static void Main7(string[] args)
        {

            CTransaction trA = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };
            CTransaction trB = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };

            // Alice      -> Bob        : $100
            Console.WriteLine(trA);

            // Alice      -> Bob        : $100
            Console.WriteLine(trB);
            Console.WriteLine($"trA equals to trB : {trA.Equals(trB)}");    // False

            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };

            // Alice      -> Bob        : $100
            Console.WriteLine(tr1);

            // Alice      -> Bob        : $100
            Console.WriteLine(tr2);
            Console.WriteLine($"tr1 equals to tr2 : {tr1.Equals(tr2)}");    // True
        }
    }
}
