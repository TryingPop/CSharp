using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.13
 * 내용 : 코드 2-49
 * 
 * var 키워드의 제약
 */

namespace Book.Ch02
{
    internal class ex49
    {
        static void Main49(string[] args)
        {
            // float 으로 저장하고 싶다면 f를 뒤에 붙여야한다
            // 안붙이면 double 타입이 된다
            var number = 10.2f;
            

            Console.WriteLine("number : " + number.GetType());
            

            // number = "변경";
            // 파이썬과 달리
            // 다른 타입의 변수로 변경이 불가능하다

        }
    }
}
