using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch05.Sub5;

/* 날짜 : 2022.07.19
 * 내용 : 다형성 실습하기 교재 p340
 * 
 * 다형성(Polymorphism)
 *  - 상속관계에서 부모클래스의 기능이 자식클래스에서 여러 기능으로 변하는 특성
 *  - 생성된 객체의 타입을 부모클래스로 선언
 */

namespace Ch05
{
    internal class _6_다형성
    {
        // 다형성 = 오버라이드
        // virtual - override : 자식클래스의 것으로 덮어 쓴다
        // virtual - new : 자식클래스의 메서드가 나오는게 아니라 부모클래스의 것이 나온다
        // virtual 지우면 animal로 통일
        // 만약 자식 클래스에 변수 a가 있고, 부모에 변수 a가 없으면 변수 a를 참조 못한다
        static void Main6(string[] args)
        {
            // 다형성을 적용한 객체 생성
            // 
            Animal a1 = new Tiger();
            Animal a2 = new Eagle();
            Animal a3 = new Shark();

            
            a1.Move();
            a2.Move();
            a3.Move();

            Console.WriteLine();

            // 객체 타입 변환(캐스팅)
            Tiger tiger = (Tiger)a1;
            Eagle eagle = a2 as Eagle;
            // Eagle eagle a2 as Tiger 
            // 에러 뜬다
            Shark shark = a3 as Shark;

            tiger.Move();
            eagle.Move();
            shark.Move();
            Console.WriteLine();
            if (a1 is Tiger) 
            {
                Console.WriteLine("a1은 Tiger입니다.");
            }
            if (a2 is Eagle) 
            {
                Console.WriteLine("a2는 Eagle입니다.");
            }
            if (a3 is Shark) 
            {
                Console.WriteLine("a3는 Shark입니다.");
            }
        }


    }
}
