using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 22.08.01
 * 내용 : dynamic - object, var 동적 타입
 */

namespace Private
{
    internal class _05_dynamic
    {
        static void Main5(string[] args)
        {
            // var - static 타입
            var apple1 = "사과";
            // 자동완성 기능 제공 - 인텔리센스 제공
            Console.WriteLine(apple1.Length);

            // dynamic - object와 유사
            // object는 캐스팅이 필요한 반면
            // dynamic은 캐스팅이 필요 없다
            dynamic apple2 = "사과";
            // 자동완성 기능 제공 X - 인텔리센스 제공 X
            Console.WriteLine(apple2.Length);

            // dynamic은 보통 메서드를 쓸 때 이용할 수 있다.
            Print("15513");
            Print(1000);
            Print(10.5f);
            Print(true);
            Print(DateTime.Now);
        }

        public static void Print(dynamic val)
        {
            Console.WriteLine(val.GetType());
        }
    }
}

// 참고 사이트
// https://spaghetti-code.tistory.com/32 
// https://www.csharpstudy.com/CSharp/CSharp-dynamic.aspx 
// dynamic은 var와 달리 컴파일에서 타입이 해석되지 않고 런타임에서 타입이 해석
// 최적화가 안되고 오류에 취약해서 성능 저하가 있을 수 있다