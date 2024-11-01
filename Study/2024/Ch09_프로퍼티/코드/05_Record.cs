using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 레코드 형식의 불변 객체
    교재 p 337 ~ 340

    불변(Immutable) 객체는 내부 상태(데이터)를 변경할 수 없는 객체를 말한다.
    상태를 변경할 수 없다는 특성 때문에 불변 객체에서는 데이터 복사와 비교가 많이 이뤄진다.
    Record는 불변 객체에서 빈번하게 이뤄지는 기존 상태를 복사한 뒤 이중 일부를 수정해 새로운 객체를 만들고,
    상태를 확인하기 위해 객체의 내용을 자주 비교하는 연산을 편리하게 수행할 수 있도록 C# 9.0에서 도입된 기능이다.

    readonly struct의 필드가 많으면 복사 비용은 커진다.
    여러 곳에서 사용하는 경우엔 더 커진다.
    참조형식은 이런 오버헤드가 없다.

    참조 형식은 프로그래머가 깊은 복사를 구현해야 한다.
    값 형식은 객체를 비교할 때 모든 필드를 1:1로 비교한다.

    불변 객체에 필요한 비교 방법이다.
    불변 객체를 참조 형식으로 선언하면 함수 호출 인수나 컬렉션 요소로 사용할 때 복사 비용을 줄일 수 있다.

    record 키워드와 초기화 전용 자동 구현 프로퍼티를 함께 이용해서 선언한다.
*/

namespace Study._2024.Ch09_프로퍼티.코드
{
    internal class _05_Record
    {

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

        static void Main5(string[] args)
        {

            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = new RTransaction { From = "Alice", To = "Charlie", Amount = 100 };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
        }
    }
}
