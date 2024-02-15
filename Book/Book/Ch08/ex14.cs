using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 날짜 : 2022.07.26
 * 내용 : 코드 8-14
 * 
 * 구조체에서 클래스 인스턴스를 멤버 변수로 선언
 */

namespace Book.Ch08
{
    internal class ex14
    {
        struct Point
        {
            public int x;
            public int y;
            public ex14 ex14;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                // 클래스 인스턴스 초기화가 필요하다면 null로 초기화!
                this.ex14 = null;
            }
        }
        static void Main14(string[] args)
        {
        }
    }
}
