using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 10. 30
이름 : 배성훈
내용 : 메소드의 결과를 참조로 반환하기
    교재 p 197 ~ 200

    메소드의 결과를 참조로 반환하는 참조 반환값(ref return)도 있다
    참조 반환값을 이용하면 호출자로 하여금 반환받은 결과를 참조로 다룰 수 있다
*/

namespace Study._2024.Ch06_메소드.코드
{
    internal class _05_RefReturn
    {

        class Product
        {

            private int price = 100;

            public ref int GetPrice()
            {

                return ref price;
            }

            public void PrintPrice()
            {

                Console.WriteLine($"Price: {price}");
            }
        }

        static void Main5(string[] args)
        {

            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();                                            // 100
            Console.WriteLine($"Ref Local Price: {ref_local_price}");       // 100
            Console.WriteLine($"Normal Local Price: {normal_local_price}"); // 100

            ref_local_price = 200;

            carrot.PrintPrice();                                            // 200
            Console.WriteLine($"Ref Local Price: {ref_local_price}");       // 200
            Console.WriteLine($"Normal Local Price: {normal_local_price}"); // 100
        }
    }
}
