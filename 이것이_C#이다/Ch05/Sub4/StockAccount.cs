using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class StockAccount : Account
    {
        private string stock;
        private int amount;
        private int price;

        public StockAccount(string bank, 
                            string id, 
                            string name, 
                            int balance, 
                            string stock, 
                            int amount, 
                            int price) : base(bank, id, name, balance)
        {
            this.stock = stock;
            this.amount = amount;
            this.price = price;
        }

        public void Sell(int amount, int price)
        {
            this.amount -= amount;
            this.price = price;
            base.balance += amount * price;
        }

        public void Buy(int amount, int price)
        {
            this.amount += amount;
            this.price = price;
            base.balance -= amount * price;
        }

        // Override
        public override void Show()
        {
            base.Show();
            Console.WriteLine("-----------------");
            Console.WriteLine("주식종목 : {0}", this.stock);
            Console.WriteLine("주식수량 : {0}", this.amount);
            Console.WriteLine("주식가격 : {0}", this.price);
            Console.WriteLine("-----------------");
        }
    }
}
