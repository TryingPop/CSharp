using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 참조 클래스 명에서 ctrl + . 누르기
using Ch05.Sub1;

/* 날짜 : 2022.07.18
 * 내용 : 클래스 실습하기 교재 p203
 * 
 * 클래스(Class)
 *  - 클래스는 객체를 생성하는 구조체이며, 필드와 메서드로 구성된다.
 *  - 객체는 클래스의 실제 인스턴스로 new 연산을 통해서 생성된다.
 */

/*
// OOP : 객체간 상호 작용을 개발하는 프로그래밍 기법 (대규모 소프트웨어)
// 객체 : 필드, 메서드 >> 객체의 추상화
// 캡슐화 : 노출의 최소화하고 필요한 정보만 노출하는 기법
// 상속 : 기존 클래스의 기능을 물려받아 사용
// 다형성 : 같은 요소를 여러개 생성
 */

namespace Ch05
{
    internal class _1_클래스
    {
        static void Main1(string[] args)
        {
            // 객체 생성
            // new : heap으로 올리는거
            Car sonata = new Car();

            // 객체 초기화
            sonata.name = "소나타";
            sonata.color = "흰색";
            sonata.speed = 10;

            sonata.SpeedUp(80);
            sonata.SpeedDown(20);
            sonata.Show();

            // 객체 생성
            Car benz = new Car();
            benz.name = "벤츠";
            benz.color = "검정";
            benz.speed = 0;
            // C++ 은 benz->name으로 표현

            benz.SpeedUp(100);
            benz.SpeedDown(20);
            benz.Show();

            // Account 객체 생성
            // 바로 은행명 부분 초기값 설정
            Account kb = new Account() { bank = "국민은행" };
            Account wr = new Account() { bank = "우리은행" };

            // 객체 초기화
            kb.id = "101-12-1010";
            kb.name = "김유신";
            kb.balance = 10000;

            // 객체 활용
            wr.id = "101-22-2020";
            wr.name = "김춘추";
            wr.balance = 30000;

            // Account 객체 활용
            kb.Deposit(40000);
            kb.Withdraw(5000);
            kb.Show();

            wr.Deposit(70000);
            wr.Withdraw(50000);
            wr.Show();
        }
    }
}

// 메모리
// stack에 sonata 생성(주소가 들어간다)
// 동시에 heap에 Car가 인스턴스로 생성된다(주소 랜덤)
// 필드들도 heap에 저장
// heap은 객체가 저장되는 메모리 공간

// 메서드사용으로 heap의 값 변경

// 이후 stack에 benz 주소 저장
// 마찬가지로 heap에 Car가 인스턴스로 생성

// 다쓰고 나면 즉, 참조카운터가 0이되면 gc에의해서 위에서 부터 빠져나간다
// heap에서 빠지는 때는 랜덤(쓰레드? 따로?)

// 멀티 스레드의 경우 메인 쪽에 있는 갈비지 컬렉션이 다른 쓰레드의 메모리 수집

