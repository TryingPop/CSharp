using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Account
    {
        protected string bank;
        protected string id;
        protected string name;
        protected int balance;

        public Account(string bank, string id, string name, int balance)
        {
            this.bank = bank;
            this.id = id;
            this.name = name;
            this.balance = balance;
        }

        public void Deposit(int money)
        {
            this.balance += money;
        }

        public void Withdraw(int money)
        {
            this.balance -= money;
        }

        public virtual void Show()
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
