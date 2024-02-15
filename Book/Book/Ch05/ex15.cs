using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 5-15
 * 
 * 인스턴스 변수를 생성과 동시에 초기화
 */

namespace Book.Ch05
{
    internal class ex15
    {
        class Product
        {
            // 인스턴스 변수
            public string name;
            public int price;
        }

        static void Main15(string[] args)
        {
            // 맨 앞에 클래스 이름 기억할 변수명 = new(생성자) 클래스();
            // 클래스가 생성된다
            Product productA = new Product() { name = "감자", price = 2000 };
            Product productB = new Product() { name = "고구마", price = 3000 };
        }
    }
}
