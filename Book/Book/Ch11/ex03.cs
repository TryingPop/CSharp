
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 11-3
 * 
 * 람다 기본
 */

namespace Book.Ch11
{
    internal class ex03
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
        static void Main3(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Name = "감자", Price = 500 },
                new Product() { Name = "사과", Price = 700 },
                new Product() { Name = "고구마", Price = 400 },
                new Product() { Name = "배추", Price = 600 },
                new Product() { Name = "상추", Price = 300 }
            };

            // 람다 이용
            // (Product a, Product b)에서 Product 생략 가능
            products.Sort((Product a, Product b) =>
            {
                return a.Price.CompareTo(b.Price);
            });



            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} : {item.Price}");
            }

        }

    }
}
