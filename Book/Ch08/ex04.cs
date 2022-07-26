using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-4
 * 
 * 인덱서 선언
 */

namespace Book.Ch08
{
    internal class ex04
    {
        class Products 
        {
            public int this[int i]
            {
                // Products products = new Product();
                // products[i] 할 때 호출
                get { return i; }
                set { Console.WriteLine("{0}번째 상품 설정", i); }
            }
        }

        static void Main4(string[] args)
        {

        }
    }
}
