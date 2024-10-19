using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 9-3
 * 
 * IComparable 인터페이스의 메서드 생성
 */

namespace Book.Ch09
{
    internal class ex03
    {
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return String.Format("{0} : {1}원", this.Name, this.Price);
            }

            public int CompareTo(object? obj)
            {
                throw new NotImplementedException();
            }
        }

        static void Main3(string[] args)
        {
        }
    }
}
