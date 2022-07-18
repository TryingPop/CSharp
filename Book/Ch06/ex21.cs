using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-20_1
 * 
 * 소멸자
 */

namespace Book.Ch06
{
    internal class ex21
    {
        class Product
        {
            public string name;
            public int price;

            public Product(string name, int price)
            {
                this.name = name;
                this.price = price;
                Console.WriteLine("name : {0}", name);
                Console.WriteLine("price : {0}", price);
            }

            ~Product()
            {
                Console.WriteLine(this.name + "의 소멸자 호출");
            }
        }

        static void Main(string[] args)
        {
            Product product = new Product("과자", 1000);
        }
    }
}