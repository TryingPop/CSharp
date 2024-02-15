using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub1
{
    internal class Account
    {
        // 속성
        public string bank;
        public string id;
        public string name;
        public int balance;

        // 기능
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
