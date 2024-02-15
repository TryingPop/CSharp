using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.22
 * 내용 : 코드 6-25
 * 
 * readonly 키워드
 */

namespace Book.Ch06
{
    internal class ex25
    {
        class Product
        {
            private static int count;
            // 생성자에서만 값 변환 가능
            // 상수는 생성자에서도 변환 불가능하므로 상수랑 차이가 있다
            public readonly int id;
            public string name;
            public int pirce;

            public Product(int id, string name, int pirce)
            {
                this.id = count++;
                this.name = name;
                this.pirce = pirce;
            }
        }
        static void Main25(string[] args)
        {

        }
    }
}