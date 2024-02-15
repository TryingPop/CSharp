using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ch05.Sub2;

/* 날짜 : 2022.07.18
 * 내용 : 캡슐화 실습하기 교재 p203
 * 
 * 캡슐화(Encapsulation)
 *  - 캡슐화는 객체의 내용(필드)을 외부에서 참조하지 못하도록 객체의 정보를 은닉하는 특성
 *  - 캡슐화를 위해 접근 제한자 public, private, protected를 사용
 *  - 은닉된 정보의 안전한 제공을 위해 Getter, Setter을 사용(프로퍼티)
 */

// 클래스가 속한 영역
namespace Ch05
{
    internal class _2_캡슐화
    {
        static void Main2(string[] args)
        {
            // 클래스안 private 변수는 바로 직접 참조할 수가 없다
            // 메서드를 통해서만 참조가능
            Account kb = new Account("국민은행", "101-12-1010", "김유신", 10000);
            Account wr = new Account("우리은행", "102-12-1010", "김춘추", 7000);

            kb.Deposit(40000);
            kb.Withdraw(5000);

            // 캡슐화로 취약코드 예방
            // 외부에서 속성 접근 불가능
            // kb.balance--;

            kb.Show();


            Car sonata = new Car(name: "소나타", "검정색", 80);
            Car benz = new Car(name: "벤츠", color: "흰색", speed: 100);

            sonata.SpeedUp(100);
            sonata.SpeedDown(20);
            sonata.Show();

            // Getter, Setter 활용 : C#에서 프로퍼티(property)라고 함
            // Setter
            // 터무니 없는 값 방지용
            benz.Color = "회색";
            benz.Speed = -100;
            // Getter
            Console.WriteLine("benz.color : {0}", benz.Color);


            Console.WriteLine();
            benz.Show();
        }
    }
}
