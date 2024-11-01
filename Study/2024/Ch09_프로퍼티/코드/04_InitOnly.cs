using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 초기화 전용 자동 구현 프로퍼티
    교재 p 334 ~ 337

    구조체에서는 readonly로 생성시에만 데이터를 수정가능하게했다.
    C# 9.0에서 프로퍼티는 init 키워드를 이용해 생성자에서만 필드를 초기화하게 할 수 있다.
*/

namespace Study._2024.Ch09_프로퍼티.코드
{
    internal class _04_InitOnly
    {

        class Transaction
        {

            public string From { get; init; }
            public string To { get; init; }
            public int Amount { get; init; }

            public override string ToString()
            {

                return $"{From,-10} -> {To,-10} : ${Amount}";
            }
        }

        static void Main4(string[] args)
        {
            
            Transaction tr1 = new Transaction { From = "Alice", To = "Bob", Amount = 100 };
            Transaction tr2 = new Transaction { From = "Bob", To = "Charlie", Amount = 50 };
            Transaction tr3 = new Transaction { From = "Charlie", To = "Alice", Amount = 50 };

            // Alice      -> Bob        : $100
            Console.WriteLine(tr1);

            // Bob        -> Charlie    : $50
            Console.WriteLine(tr2);

            // Charlie    -> Alice      : $50
            Console.WriteLine(tr3);
        }
    }
}
