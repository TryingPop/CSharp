using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
날짜 : 2024. 11. 1
이름 : 배성훈
내용 : 추상 클래스와 프로퍼티
    교재 p 349 ~ 352

    추상 클래스는 구현되거나 구현안된 프로퍼티를 가질 수 있다.
    추상 프로퍼티 역시 인터페이스 프로퍼티와 다를 것이 없다.

    추상 프로퍼티는 abstract 키워드를 추가해 정의할 수 있다.
*/

namespace Study._2024.Ch09_프로퍼티.코드
{
    internal class _10_PropertiesInAbstractClass
    {

        abstract class Product
        {

            private static int serial = 0;
            public string SerialID
            {

                get { return String.Format("{0:d5}", serial++); }
            }

            // public int Amount { get; set; }

            public abstract DateTime ProductDate
            {

                get;
                set;
            }
        }

        class MyProduct : Product
        {

            public override DateTime ProductDate
            {

                get;
                set;
            }
        }

        static void Main10(string[] args)
        {

            Product product_1 = new MyProduct() { ProductDate = new DateTime(2018, 1, 10) };

            // Product: 00000, Product Date: 2018-01-10 오전 12:00:00
            Console.WriteLine("Product: {0}, Product Date: {1}", 
                product_1.SerialID, product_1.ProductDate);

            Product product_2 = new MyProduct() { ProductDate = new DateTime(2018, 2, 3) };

            // Product: 00001, Product Date: 2018-02-03 오전 12:00:00
            Console.WriteLine("Product: {0}, Product Date: {1}",
                product_2.SerialID, product_2.ProductDate);
        }
    }
}
