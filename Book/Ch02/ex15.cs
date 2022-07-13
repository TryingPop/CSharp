using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.12
 * 내용 : 코드 2-15
 * 
 * 문자열 연결 연산자
 */

namespace Book.Ch02
{
    internal class ex15
    {
        static void Main15(string[] args)
        {
            Console.WriteLine("가나다"+"라마"+"바사아"+"자차카타"+"파하");
            // 문자와 문자열을 연결 가능하다
            // 문자와 문자끼리는 안된다 2-18 참조
            Console.WriteLine('A' + "가");

            // 변수와도 연결이 가능하다
            int num = 3;
            Console.WriteLine("가 : " + num);
        }
    }
}
