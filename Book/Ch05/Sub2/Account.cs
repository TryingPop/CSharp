using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Account
    {
        // 속성
        private string bank;
        private string id;
        private string name;
        private int balance;

        // 생성자
        // 매개변수는 똑같이 선언하면 된다
        /*
                public Account(string bank, string id, string name, int balance)
                {
                    this.bank = bank;
                    this.id = id;
                    this.name = name;
                    this.balance = balance;
                }
        */        // 클래스안 private 변수는 바로 직접 참조할 수가 없다
        // 메서드를 통해서만 참조가능

        // 속성들 드래그하고 mouse 마우스 우측 클릭 맨 위에 항목 클릭
        // 그러면 빠르게 생성자 생성

        // 생성화 : 캡슐화된 속성을 초기화하기 위한 메서드
        public Account(string bank, string id, string name, int balance)
        {
            this.bank = bank;
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        // 기능 : 일반적으로 외부에 기능을 제공하기위해 public 선언
        // 예금
        public void Deposit(int money)
        {
            // 그냥 balance로 해도 상관없다
            this.balance += money;
        }

        // 출금
        public void Withdraw(int money)
        {
            this.balance -= money;
        }

        // 확인
        public void Show()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("은행명 : {0}", this.bank);
            Console.WriteLine("계좌번호 : {0}", this.id);
            Console.WriteLine("입금주 : {0}", this.name);
            Console.WriteLine("현재잔액 : {0}", this.balance);
            Console.WriteLine("-----------------");
        }
    }
}
