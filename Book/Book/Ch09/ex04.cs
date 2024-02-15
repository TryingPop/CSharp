using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 9-4
 * 
 * CompareTo() 메서드 구현
 */

namespace Book.Ch09
{
    internal class ex04
    {
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return String.Format("{0} : {1}원", this.Name, this.Price);
            }

            public int CompareTo(object obj)
            {
                return this.Price.CompareTo((obj as Product).Price);
            }
        }

        static void Main4(string[] args)
        {
        }
    }
}
