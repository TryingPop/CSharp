using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 9-2
 * 
 * IComparable 인터페이스 상속
 */

namespace Book.Ch09
{
    internal class ex02
    {
        class Product // : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return String.Format("{0} : {1}원", this.Name, this.Price);
            }
        }

        static void Main2(string[] args)
        {
        }
    }
}
