
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.27
 * 내용 : 코드 11-2
 * 
 * 무명 델리게이터 기본
 */

namespace Book.Ch11
{
    internal class ex02
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
        static void Main2(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Name = "감자", Price = 500 },
                new Product() { Name = "사과", Price = 700 },
                new Product() { Name = "고구마", Price = 400 },
                new Product() { Name = "배추", Price = 600 },
                new Product() { Name = "상추", Price = 300 }
            };
            
            // Sort가 받는 인자 delegate Comparison은 2개 비교를 하는 메서드면 형태다
            products.Sort(delegate (Product a, Product b)
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
