using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 11-1
 * 
 * 
 */

namespace Book.Ch11
{
    internal class ex01
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
        static void Main1(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Name = "감자", Price = 500 },
                new Product() { Name = "사과", Price = 700 },
                new Product() { Name = "고구마", Price = 400 },
                new Product() { Name = "배추", Price = 600 },
                new Product() { Name = "상추", Price = 300 }
            };

            // List안에 Sort의 인자는 Delegater
            // 그래서 메서드를 인자로 받을 수 있다
            products.Sort(SortWithPrice);

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} : {item.Price}");
            }

        }

        static int SortWithPrice(Product a, Product b)
        {
            return a.Price.CompareTo(b.Price);
        }
    }
}
