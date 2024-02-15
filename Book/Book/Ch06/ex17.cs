using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-17
 * 
 * 인스턴스 생성 개수 확인
 */

namespace Book.Ch06
{
    internal class ex17
    {
        class Product 
        {
            public static int counter = 0;
            public int id;
            public string name;
            public int price;

            // Python에서 init 메서드와 동일
            public Product(string name, int price)
            {
                // counter : 클래스 변수
                Product.counter = counter + 1;
                // this 쓰면 인스턴스 변수로 변환된다
                this.id = counter;
                this.name = name;
                this.price = price;
            }
        }

        static void Main17(string[] args)
        {
            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);

            Console.WriteLine($"{productA.id} : {productA.name}");
            Console.WriteLine($"{productB.id} : {productB.name}");

            // Python과 같이 클래스 변수는
            // 클래스명.클래스 변수로 접근 가능하다
            Console.WriteLine($"{Product.counter}");

            // 오류 뜬다
            // productA.counter = 5;
            
            // 오류 뜬다
            // string productA.a = "?";
            
        }
    }
}
