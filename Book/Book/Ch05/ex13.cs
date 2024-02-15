using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-13
 * 
 * 인스턴스 변수 사용
 */

namespace Book.Ch05
{
    internal class ex13
    {
        class Product
        {
            // 인스턴스 변수
            public string name;
            public int price;
        }

        static void Main13(string[] args)
        {
            // 맨 앞에 클래스 이름 기억할 변수명 = new(생성자) 클래스();
            // 클래스가 생성된다
            Product product = new Product();

            product.name = "감자";
            product.price = 2000;

            Console.WriteLine("{0} : {1} 원", product.name, product.price);
        }
    }
}
