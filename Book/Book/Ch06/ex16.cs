using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.15
 * 내용 : 코드 6-16
 * 
 * 기본적인 생성자의 모습
 */

namespace Book.Ch06
{
    internal class ex16
    {
        class Product 
        {
            public string name;
            public int price;

            public Product(string name, int price)
            {
                // this : 자기자신을 나타내는 키워드
                // Python의 self와 동일
                this.name = name;
                this.price = price;
            }
        }
    }
}
