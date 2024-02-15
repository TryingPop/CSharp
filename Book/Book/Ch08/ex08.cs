using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-8
 * 
 * new 키워드를 사용하지 않고 구조체 인스턴스 생성
 */

namespace Book.Ch08
{
    internal class ex08
    {
        struct Point
        {
            public int x;
            public int y;
        }

        static void Main8(string[] args)
        {
            Point point;
            // x를 선언하기 전에 x속성을 불러올 수 없다.
            // Console.WriteLine(point.x);
            point.x = 10;
            point.y = 10;

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }
}
